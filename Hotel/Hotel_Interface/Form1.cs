using Project_Hotel.Controllers;
using Project_Hotel.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private AccountController accountController = new AccountController();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Account account = accountController.getAccountById(1);

            //loggedMessage.Text = account.Name;
            //loggedMessage.Text = account.Password;

            Account account = accountController.login(loginName.Text, loginPassword.Text);

            if (loginName.Text == account.Name && loginPassword.Text == account.Password)
            {
                loggedMessage.Text = $"You have been successfully logged as {account.Name}";
                loggedMessage.ForeColor = Color.Red;
            }
            else
            {
                loggedMessage.Text = "Enter name and password to login";
                loggedMessage.ForeColor = Color.Green;
            }


            //if (loginName.Text == "" || loginPassword.Text == "")
            //{
            //    loggedMessage.Text = "Enter name and password to login";
            //    loggedMessage.ForeColor = Color.Red;
            //}
            //else
            //{
            //    Account account = accountController.login(loginName.Text, loginPassword.Text);
            //    loggedMessage.Text = $"You have been successfully logged as {account.Name}";
            //    loggedMessage.ForeColor = Color.Green;
            //}
        }
    }
}
