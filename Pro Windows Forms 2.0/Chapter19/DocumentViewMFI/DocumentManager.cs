using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DocumentView
{
	public class DocumentManager
	{
        private Dictionary<Form,string> documents =
            new Dictionary<Form,string>();
        public Dictionary<Form, string> Documents
        {
            get { return documents; }
        }

        // Track the form that has focus.
        private Form activeDocumentForm;
        public Form ActiveDocumentForm
        {
            get { return activeDocumentForm; }
        }

		public void AddForm(Form form)
		{
			if (!documents.ContainsKey(form))
			{
				documents.Add(form, form.Text);

				// Watch for activation and close events.
				form.Activated += new EventHandler(Form_Activated);
				form.Closed += new EventHandler(Form_Closed);
				
				form.TextChanged += new EventHandler(Form_TextChanged);
                OnWindowListChanged();
			}
		}

		// Provide an automatic shut-down feature when 
		// last document is closed, if desired.
		private bool quitWhenLastDocumentClosed = true;
		public bool QuitWhenLastDocumentClosed
		{
			get { return quitWhenLastDocumentClosed; }
			set { quitWhenLastDocumentClosed = value; }
		}

		private void Form_Closed(object sender, EventArgs e)
		{
            Form form = (Form)sender;
			documents.Remove(form);

			if (documents.Count == 0 && quitWhenLastDocumentClosed)
			{
				Application.Exit();
			}
            OnWindowListChanged();
		}
		
		private void Form_Activated(object sender, EventArgs e)
		{
			activeDocumentForm = (Form)sender;
		}
                
		private void Form_TextChanged(object sender, EventArgs e)
		{
            Form form = (Form)sender;
            documents[form] = form.Text;
            OnWindowListChanged();
		}

        public event EventHandler<WindowListChangedEventArgs> WindowListChanged;
        public void OnWindowListChanged()
        {
            if (WindowListChanged != null)
            {                
                WindowListChanged(this,
                    new WindowListChangedEventArgs(documents));
            }
        }
	}
}
