using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PathTools
{
    public partial class SelectForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public SelectForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();

            for (int i = 1; i < args.Length; i++)
            {
                lstPath.Items.Add(args[i].Trim());
            }
            lstPath.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFullPath_Click(object sender, EventArgs e)
        {
            StringBuilder buf = new StringBuilder();

            foreach (ListViewItem item in lstPath.Items)
	        {
                buf.AppendLine(GetText(item.Text));
	        }

            // クリップボードへ転送
            Clipboard.SetData(DataFormats.Text, buf.ToString());

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFileName_Click(object sender, EventArgs e)
        {
            StringBuilder buf = new StringBuilder();

            foreach (ListViewItem item in lstPath.Items)
            {
                buf.AppendLine(Path.GetFileName(GetText(item.Text)));
            }

            // クリップボードへ転送
            Clipboard.SetData(DataFormats.Text, buf.ToString());

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFolderName_Click(object sender, EventArgs e)
        {
            StringBuilder buf = new StringBuilder();

            foreach (ListViewItem item in lstPath.Items)
            {
                buf.AppendLine(Path.GetDirectoryName(GetText(item.Text)));
            }

            // クリップボードへ転送
            Clipboard.SetData(DataFormats.Text, buf.ToString());

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExt_Click(object sender, EventArgs e)
        {
            StringBuilder buf = new StringBuilder();

            foreach (ListViewItem item in lstPath.Items)
            {
                buf.AppendLine(Path.GetExtension(GetText(item.Text)));
            }

            // クリップボードへ転送
            Clipboard.SetData(DataFormats.Text, buf.ToString());

        }

        private String GetText(String org)
        {
            if (rdoUpper.Checked){
                return org.ToUpper();
            }
            else if (rdoLower.Checked){
                return org.ToLower();
            }
            else{
                return org;
            }
        }
    }
}
