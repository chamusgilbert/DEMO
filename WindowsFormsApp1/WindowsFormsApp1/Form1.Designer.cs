using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 254);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		private void btnLoadXML_Click(object sender, EventArgs e)

		{
			ListBox listBox1 = new ListBox();
			string path_of_xml = "XMLFile.xml";

			XmlDocument doc = new XmlDocument();

			doc.Load(path_of_xml);



			listBox1.Items.Clear();

			foreach (XmlNode node in doc.ChildNodes)

			{

				if (node.Name == "Authors")

				{

					foreach (XmlNode node_of_node in node.ChildNodes)

					{

						if (node_of_node.Name == "Author")

						{

							string firstname = node_of_node["FirstName"].InnerText;

							string lastname = node_of_node["LastName"].InnerText;

							listBox1.Items.Add(firstname + " " + lastname);

						}

					}

				}

			}



		}

		#endregion
	}
}

