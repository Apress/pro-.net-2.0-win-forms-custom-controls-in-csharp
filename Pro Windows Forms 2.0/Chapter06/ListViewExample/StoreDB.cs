using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace ListViewExample
{
	public class StoreDB
	{
		public static DataTable GetProducts()
		{
			DataSet dsStore = new DataSet();
			dsStore.ReadXmlSchema(Application.StartupPath + "\\store.xsd");
			dsStore.ReadXml(Application.StartupPath + "\\store.xml");
			return dsStore.Tables["Products"];
		}

		public static DataTable GetCategories()
		{
			DataSet dsStore = new DataSet();
			dsStore.ReadXmlSchema(Application.StartupPath + "\\store.xsd");
			dsStore.ReadXml(Application.StartupPath + "\\store.xml");
			return dsStore.Tables["Categories"];
		}
	}
}
