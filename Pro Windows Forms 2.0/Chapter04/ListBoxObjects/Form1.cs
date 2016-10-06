using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListBoxObjects
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lstCustomers.Items.Add(new Customer("Maurice", "Respighi", DateTime.Now.AddDays(-10)));
			lstCustomers.Items.Add(new Customer("Sam", "Digweed", DateTime.Now.AddDays(-100)));
			lstCustomers.Items.Add(new Customer("Faria", "Khan", DateTime.Now.AddDays(-500)));

		}

		private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
		{
			Customer cust = (Customer)lstCustomers.SelectedItem;
			MessageBox.Show("Birth Date: " + cust.BirthDate.ToShortDateString());
		}
	}
}