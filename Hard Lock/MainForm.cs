using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Hard_Lock
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        string CPU_ID = string.Empty;
        string CPU_Man = string.Empty;
        string Mac_Address = string.Empty;
        string lock_string = string.Empty;
        string Coded_Lock_String = string.Empty;

        public void Get_Informations ()
        {
            CPU_ID = GlobalMain.GetCPUId();
            CPU_Man = GlobalMain.GetCPUManufacturer();
            Mac_Address = GlobalMain.GetMACAddress();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty && txtUserName.Text == string.Empty)
            {
                MessageBox.Show("Please Type Username And Password Frist", "Login Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtUserName.Text == "mohammadtaghadosi" && txtPassword.Text == "ASDzxc")
            {
                groupBoxMainArea.Enabled = true;
                toolStripStatusLable1.Text = "Authenticated Successfully";
                toolStripStatusLable1.ForeColor = Color.Green;
                btnLogin.Enabled = false;
                txtUserName.ReadOnly = true;
                txtPassword.ReadOnly = true;
                btnCancel.Text = "Close";
            }
            else
            {
                MessageBox.Show("UserName And/Or Password is Invalid On This Software", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = string.Empty;
                txtUserName.Focus();
                txtUserName.SelectAll();
            }

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!GlobalMain.IsSoftwareInstalled())
            {
                MessageBox.Show("The software can not write the lock string into this computer because the Parking Version1 Software dosn't installed in this computer Please install the Parking Version1 First", "Locking Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                GlobalMain.WriteRegistryConfig_ForLockString(lock_string);
                MessageBox.Show("Lock has been located in this computer Successfully!", "Opration Successfull");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Certical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (GlobalMain.ClearRegistryKey())
                MessageBox.Show("Cleared Successfully", "Opration Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Can't Clear the lock string from this computer, maybe the software dosen't installed or the locked cleared before", "Opration UnCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GlobalMain.IsKeyLocated())
                MessageBox.Show("Key had been located successfully", "Information");
            else
                MessageBox.Show("Key Is not Located in this Computer", "Information");
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            this.Enabled = false;
            Application.DoEvents();
            GlobalMain.DisableCloseBotton(this.Handle, false, 0xF060, 0x1);
            Get_Informations();
            lock_string = CPU_ID + "@" + CPU_Man + "@" + Mac_Address;
            this.Enabled = true;
            Application.DoEvents();
        }

        private void lnkHELP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Hardware Lock Version 1.0.0.1\nThis software created in Intelligence Company by M.Taghadosi.", "About...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}