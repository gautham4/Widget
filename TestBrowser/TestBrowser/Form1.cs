using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Okta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser1_NewWindow_1(object sender, CancelEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "Cancel", e.Cancel);
            messageBoxCS.AppendLine();
           // MessageBox.Show(messageBoxCS.ToString(), "NewWindow Event");

            webBrowser1.Navigate(webBrowser1.StatusText);
            e.Cancel = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void Form1_Closed(object sender, FormClosedEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "Cancel", e.CloseReason);
            messageBoxCS.AppendLine();
           // MessageBox.Show(messageBoxCS.ToString(), "FormClosing Event");
        }

        public void Test(int result)
        {
            if (result == 1)
            {
                this.DialogResult = DialogResult.OK;
            } else
            {
                this.DialogResult = DialogResult.Cancel;
            }
           // MessageBox.Show("javascript Rturn ", "client code");
            this.Close();
        }

    }
}
