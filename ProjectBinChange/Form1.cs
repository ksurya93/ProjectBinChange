using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ProjectBinChange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog oDialog = new FolderBrowserDialog();
            if (oDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = oDialog.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox1.Text))
            {
                String[] files = Directory.GetFiles(textBox1.Text, "*.txt", SearchOption.AllDirectories);

                foreach(String fpath in files)
                {

                    XmlDocument doc = new XmlDocument();
                    doc.Load(fpath);
                    XmlNodeList oNode = doc.SelectNodes("/as/aw");

                    foreach (XmlNode oElem in oNode)
                    { 
                        
                    }
                    //oNode.InnerText = textBox2.Text;
                    
                    doc.Save(fpath);

                    //using (StreamWriter oWrite = new StreamWriter(fpath))
                    //{
                    //    oWrite.Write("Hi I'm in "+fpath);
                    //}
                }

            }
        }

    }
}
