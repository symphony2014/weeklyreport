using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;

namespace OutlookEmailAccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAccessEmail_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Outlook.Application myApp = new Microsoft.Office.Interop.Outlook.ApplicationClass();
            Microsoft.Office.Interop.Outlook.NameSpace mapiNameSpace = myApp.GetNamespace("MAPI");
            Microsoft.Office.Interop.Outlook.MAPIFolder myInbox = mapiNameSpace.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderInbox);
            //var items= myInbox.Items
            foreach (Microsoft.Office.Interop.Outlook.MailItem item in myInbox.Items)
            {
                if (item.CreationTime.AddDays(7)>DateTime.Now)
                {
                    txtBody.Text += item.Subject + "<br/>";
                }
            }
            var oMail = (MailItem)myApp.CreateItem(
                   Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);

            // Set the properties of the email.
            oMail.Subject = "weekly report";
            oMail.To = "v-welai@microsoft.com;v-koba.microsoft.com";
            oMail.HTMLBody = txtBody.Text;

            // Displays a new Inspector object for the item and allows users to 
            // click on the Send button to send the mail manually.
            // Modal = true makes the Inspector window modal
            oMail.Display(true);
                MessageBox.Show("There are no emails in your Inbox.");
        }
    }
}