using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Samples.RSS;

namespace System.Windows.Forms.Samples
{
	public partial class RSSView : UserControl
	{
		private string					_url = string.Empty;
		private	int					    _initialHeight;
		private bool					_showUpdate = true;
		private bool					_bound = false;
		private RssFeed					_feed;
		private BindingList<RssItem>	_items = null;
		private bool					_loaded=false;
        private bool                    _showImage = true;

		private int						_rowHeight = -1;
		private int						_height = -1;
		private int						_rowCount = -1;           // Max visible rows
		private int						_displayedRows = -1;      // # of displayed rows
		private int						_pageCount = 0;
		private int						_currentPage = 0;
        private bool                    _maximized = true;

		public RSSView()
		{
			InitializeComponent();

            // Save initialize Size
            this._initialHeight = this.Size.Height;
		}

		#region Public API
		public string HeaderText
		{
			get { return this.headerTextLabel.Text; }
			set { this.headerTextLabel.Text = value; }
		}

		[DefaultValue(true)]
		public bool ShowRefresh
		{
			get { return _showUpdate; }
			set
			{
				// Set value
				_showUpdate = value;

				if (null != _feed)
				{
					BindToUI();
				}
			}
		}

		[Browsable(false)]
		public RssFeed RssFeed
		{
			get { return _feed; }
		}

        public bool ShowImage
        {
            get { return _showImage; }
            set { _showImage = value; }
        }

        private void SetState(bool max)
        {
            if (!max)
            {
                // Checked - minimize
                this.Size = new Size(this.Size.Width, this.MinimumSize.Height);
                this.contentPanel.Visible = false;
                this.compressItem.Checked = true;
            }
            else
            {
                // Unchecked - restore
                this.contentPanel.Visible = true;
                this.compressItem.Checked = false;
                this.Size = new Size(this.Size.Width, this._initialHeight);

                // Adjust view
                AdjustView(false);
            }

            // Notify clients
            OnStateChanged(EventArgs.Empty);
        }

        public bool Maximized
        {
            get { return this.contentPanel.Visible; }
            set
            {
                if (this._maximized != value)
                {
                    // Update state
                    this._maximized = value;

                    // Change
                    SetState(value);
                }
            }
        }

        // State changed event
        public event EventHandler StateChanged;

        protected virtual void OnStateChanged(EventArgs e)
        {
            if (null != StateChanged)
            {
                StateChanged(this, e);
            }
        }

		// LinkClicked event
		public event LinkClickedEventHandler LinkClicked;

		protected virtual void OnLinkClicked(LinkClickedEventArgs e)
		{
			// Fire event
			if (null != LinkClicked)
			{
				LinkClicked(this, e);
			}
		}

		// Completed Event
		public event EventHandler LoadStart;
		public event EventHandler LoadComplete;

		protected virtual void OnLoadStart(EventArgs e)
		{
			// Set header text
			this.headerTextLabel.Text = "Loading...";

			// Set Cursor
			this.Cursor = Cursors.WaitCursor;

			// Fire event
			if (null != LoadStart)
			{
				LoadStart(this, e);
			}
		}

		protected virtual void OnLoadComplete(EventArgs e)
		{
			// Do complete work
			BindToUI();

			// Enable "Save" button if the link is not in the list
			this.addButton.Enabled = (RssLink.FindLink(this.URL) < 0);

			// Reset Cursor
			this.Cursor = Cursors.Default;

			// Fire event
			if (null != LoadComplete)
			{
				LoadComplete(this, e);
			}
		}

		[DefaultValue(null)]
		public string URL
		{
			get { return _url; }
			set
			{
				// Set value
				_url = value;

				// Refresh the UI
				if (!(String.IsNullOrEmpty(_url)) && _loaded)
				{
					Reload();
				}
			}
		}

		public void Reload()
		{
			// Fire Start
			if (InDesignMode)
			{
				// Just display header
				this.headerTextLabel.Text = _url.Remove(30) + "...";
			}
			else
			{
				OnLoadStart(EventArgs.Empty);

				// Load Feed in BackgroundWorker
				feedBackgroundWorker.RunWorkerAsync(_url);
			}
		}
		#endregion

		#region Private API
		private void BindToUI()
		{
			// Bind
			_bound = true;

			if ((null != _feed.Image) && (this.ShowImage))
			{
				// Set image
				this.pictureBox1.Image = _feed.Image;
			}

			// Set label
			this.headerTextLabel.Text = _feed.Title;

			// Set view
            this.imagePanel.Visible = ((null != _feed.Image) && (this.ShowImage));

			// Set Update
			this.updateButton.Visible = _showUpdate;

			// Adjust view
			AdjustView(true);
		}

		private void RefreshData()
		{
			// Complete refresh - re-fill the list with the current feed data.
			if (_bound)
			{
				int		start = _currentPage * _displayedRows;
				int		end = Math.Min(start + _displayedRows, _feed.Items.Count);

				// Suspend binding (for perf reasons)
				_items.RaiseListChangedEvents = false;

				// Fill List
				_items.Clear();

				for (int idx = start; idx < end; idx++)
				{
					_items.Add(_feed.Items[idx]);
				}

				// Show items
				_items.RaiseListChangedEvents = true;
				_items.ResetBindings();

				// Don't show more
				bool show = (_pageCount != 0);

				this.nextButton.Visible = show;
				this.prevButton.Visible = show;

				if (show)
				{
					this.nextButton.Enabled = (_currentPage < _pageCount);
					this.prevButton.Enabled = (_currentPage != 0);
				}
			}
		}

		private void AdjustRows(bool refresh)
		{
			if (_bound)
			{
				int		rows = (_height - 2) / _rowHeight;
				bool	visible = false;

				// Check to see if the max rows changed
				if (refresh || (rows != _rowCount))
				{
					// Update
					_rowCount = Math.Max(rows, 1);

					// Check to see if we can display more/less rows
					int displayedRows = Math.Min(_rowCount, _feed.Items.Count);

					if (refresh || (_displayedRows != displayedRows))
					{
						if (displayedRows >= _feed.Items.Count)
						{
							// We can display all rows
							visible = _showUpdate;

							// Reset page
							_pageCount = 0;
						}
						else
						{
							// Need to page
							visible = true;

							// Calculate Page Count
							_pageCount = ((_feed.Items.Count - 1) / _rowCount);
						}

						// Set values
						_currentPage = 0;
						_displayedRows = displayedRows;

						// Display rows
						RefreshData();
					}
				}
			}
		}

		private void AdjustView(bool refresh)
		{
			if (_bound)
			{
				// If the height changed, then we need to refresh and adjust the # of rows
				if (refresh || ((null != _feed.Items) && (this.dataGridView1.Height != _height)))
				{
					_height = this.dataGridView1.Height;
					AdjustRows(refresh);
				}
			}
		}

		private void dataGridView1_SizeChanged(object sender, EventArgs e)
		{
			AdjustView(false);
		}

		private void nextButton_Click(object sender, EventArgs e)
		{
			// More clicked
			_currentPage++;

			// Display data
			RefreshData();
		}

		private void prevButton_Click(object sender, EventArgs e)
		{
			// Prev clicked
			_currentPage--;

			// Refresh
			RefreshData();
		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			Reload();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (!(string.IsNullOrEmpty(this.dataGridView1.Columns[e.ColumnIndex].DataPropertyName)))
			{
				RssItem item = _items[e.RowIndex];
			}
		}

		private bool ControlInDesignMode(Control ctrl)
		{
			return ((ctrl != null) && (null != this.Site) && (this.Site.DesignMode == true));
		}

		private bool InDesignMode
		{
			get { return (ControlInDesignMode(this) || (ControlInDesignMode(this.Parent))); }
		}
		#endregion

		#region Event Handlers
		private void compressItem_CheckedChanged(object sender, EventArgs e)
		{
            this.Maximized = !this.compressItem.Checked;
		}

		private void RSSView_Load(object sender, EventArgs e)
		{
			// Set Font
			this.headerTextLabel.Font = new Font(SystemFonts.IconTitleFont, FontStyle.Bold);

			// Set defaults
			_rowHeight = this.dataGridView1.RowTemplate.Height;

			// Create list
			_items = new BindingList<RssItem>();

			// Bind grid
			this.RssItemBindingSource.DataSource = _items;

			// Set Loaded flag
			_loaded = true;

			// Check for load required
			if (!String.IsNullOrEmpty(this.URL))
			{
				Reload();
			}
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			RssLink.Add(_feed.Title, this.URL);
			this.addButton.Enabled = false;
		}

		private void closeItem_Click(object sender, EventArgs e)
		{
			this.Parent.Controls.Remove(this);
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if ((e.RowIndex >= 0) && (e.RowIndex < _items.Count))
			{
				OnLinkClicked(new LinkClickedEventArgs(_items[e.RowIndex].Link));
			}
		}

		private void feedBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			// This method will run on a thread other than the UI thread.
			// Be sure not to manipulate any Windows Forms controls created
			// on the UI thread from this method.

			RssFeed		feed = new RssFeed();

			// Load
			feed.Load(e.Argument as string);

			// Return result
			e.Result = feed;
		}

		private void feedBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			// Got the feed
			_feed = (e.Result as RssFeed);

			// Notify others
			OnLoadComplete(EventArgs.Empty);
		}
		#endregion
	}

	#region Link Clicked Event
	public class LinkClickedEventArgs : EventArgs
	{
		private string _url = null;

		/// <devdoc>
		///     Initializes a new instance of the <see cref='System.ComponentModel.AddingNewEventArgs'/> class,
		///     with no new object defined.
		/// </devdoc>
		public LinkClickedEventArgs() : base()
		{
		}

		/// <devdoc>
		///     Initializes a new instance of the <see cref='System.ComponentModel.AddingNewEventArgs'/> class,
		///     with the specified object defined as the default new object.
		/// </devdoc>
		public LinkClickedEventArgs(string url) : base()
		{
			_url = url;
		}

		/// <devdoc>
		///     Gets or sets the new object that will be added to the list.
		/// </devdoc>
		public string URL
		{
			get { return _url; }
			set { _url = value; }
		}
	}

	public delegate void LinkClickedEventHandler(object sender, LinkClickedEventArgs e);

	#endregion
}
