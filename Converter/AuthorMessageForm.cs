using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Converter
{
    public partial class AuthorMessageForm : Form
    {
        public AuthorMessageForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void lnkWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenPage("http://sqlitecompare.com");
        }

        public static void OpenPage(string url)
        {
            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo(url);
            p.StartInfo = psi;
            psi.UseShellExecute = true;
            p.Start();
        }
    }
}