using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{ }

			XmlTextReader Xreader = new XmlTextReader(HttpContext.Current.Server.MapPath("toolbox.xml"));
			Xreader.WhitespaceHandling = WhitespaceHandling.None;
			XmlDocument Xdoc = new XmlDocument();
			Xdoc.Load(Xreader);
			lst_company.Items.Add("LIST OF CONTROLS");
			lst_company.Items.Add(" ");
			lst_company.Items.Add(" ");
			XmlNode Xnode = Xdoc.DocumentElement;
			AddText(Xnode, 1);


			private void AddText(XmlNode Xnode, Int32 intlevel)
			{
				XmlNode Xnodeworking;
				String strindent = new string(' ', 2 * intlevel);
				string strvalue = (string)Xnode.Value;
				if (strvalue != null)
				{
					strvalue = " : " + strvalue;
				}
				if (Xnode.NodeType == XmlNodeType.Element)
				{
					XmlNamedNodeMap mapattributes = Xnode.Attributes;
					foreach (XmlNode xnodattribute in mapattributes)
					{
						lst_company.Items.Add(strindent + " " + xnodattribute.Name + ":" + xnodattribute.Value);
						lst_company.Items.Add(" ");
					}
					if (Xnode.HasChildNodes)
					{
						Xnodeworking = Xnode.FirstChild;
						while (Xnodeworking != null)
						{
							AddText(Xnodeworking, intlevel + 1);
							Xnodeworking = Xnodeworking.NextSibling;
						}
					}
				}
			}
	}
}
