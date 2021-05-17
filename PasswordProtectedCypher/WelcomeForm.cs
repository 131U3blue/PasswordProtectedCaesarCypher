using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PasswordProtectedCypher
{
    public partial class WelcomeForm : Form
    {
        int accountExists = 0;
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (IsUsernameInputValid(tbUsername.Text) && IsPasswordInputValid(tbPassword.Text)) {
                if (DatabaseFunctions.AttemptSecureLogin(tbUsername.Text, tbPassword.Text)) { this.Hide(); }
            }
        }

        private void btnSwitchToRegister_Click(object sender, EventArgs e)
        {
            accountExists += 1;
            if (accountExists % 2 != 0) {
                this.Text = "Register";
                lblCreateAccount.Text = "Got an account?";
                lblLogin.ForeColor = Color.FromName("InactiveCaption");
                lblRegister.ForeColor = Color.FromName("ControlText");
                btnSwitchToRegister.Text = "Click here to log in to an account";
                btnConnect.Enabled = false;
                btnRegister.Enabled = true;

            }
            else {
                this.Text = "Log In";
                lblCreateAccount.Text = "Not registered?";
                lblLogin.ForeColor = Color.FromName("ControlText");
                lblRegister.ForeColor = Color.FromName("InactiveCaption");
                btnSwitchToRegister.Text = "Click here to create an account";
                btnConnect.Enabled = true;
                btnRegister.Enabled = false;
            }
            tbUsername.Clear();
            tbPassword.Clear();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (IsUsernameInputValid(tbUsername.Text) && IsPasswordInputValid(tbPassword.Text)) {
                if (DatabaseFunctions.RegisterUser(tbUsername.Text, tbPassword.Text)) {
                    MessageBox.Show("Account Created!", "Success!");
                    btnSwitchToRegister.PerformClick();
                }
            }
        }
        private bool IsUsernameInputValid(string userInput)
        {
            bool validity = true;
            foreach(char c in userInput) {
                if (!Char.IsLetterOrDigit(c)) {
                    validity = false;
                    MessageBox.Show("Username cannnot contain spaces or special characters.");
                    break;
                }
                else continue;
            }
            if (userInput.Length < 1) { 
                validity = false;
                MessageBox.Show("No username entered.");
            }
            return validity;
        }
        private bool IsPasswordInputValid(string userInput)
        {
            bool validity = true;
            foreach(char c in userInput) {
                if (Char.IsWhiteSpace(c) || Char.IsPunctuation(c)) {
                    validity = false;
                    MessageBox.Show("Password cannot contain spaces or punctuation.");
                    break;
                }
                else continue;
            }
            if (userInput.Length < 1) { 
                validity = false;
                MessageBox.Show("No password entered.");
            }
            return validity;
        }
    }
}
