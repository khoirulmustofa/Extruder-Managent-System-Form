using ExtruderManagementSystem_Entity;
using ExtruderManagementSystem_Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtruderManagementSystem_UI.Admin;
using ExtruderManagementSystem_UI.Extruder;
using ExtruderManagementSystem_UI.PPIC;
using ExtruderManagementSystem_UI.Spec_System;

namespace ExtruderManagementSystem_UI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            try
            {
                bool dialogKeluar = MessageBox.Show("Apakah Anda Akan Keluar dari Aplikasi", "Keluar Apliksi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                if (dialogKeluar)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroor Aplikasi Adalah : " + ex.ToString(), "Error Aplikasi");
            }
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            string userID = txtUserID.Text;
            //string userID = "111";
            try
            {
                masukAplikasi(userID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroor Aplikasi Adalah : " + ex.ToString(), "Error Aplikasi");
            }
        }

        private void masukAplikasi(string userID)
        {

            // kondisi untuk cek ,bypasslogin keperluan devlop
            if (ConfigurationManager.AppSettings["IsByPassLogin"].ToString() == "1")
            {
                FormAdminMenu oFormAdminMenu = new FormAdminMenu();
                oFormAdminMenu.UserID = userID;
                oFormAdminMenu.Show();
                this.Hide();

            }
            else
            {
                // cek user aktif atau tidak terdaftar
                if (IsUserActive(userID))
                {
                    //string pass = txtPasswords.Text;
                    string pass = "123";
                    if (verifycationUser(userID, pass))
                    {
                        MASAUser oMASAUser = new MASAUser_Facade().getMASAUserById(DomainName + "/" + userID);
                        if (oMASAUser.Description.Equals("Administrator"))
                        {
                            FormAdminMenu oFormAdminMenu = new FormAdminMenu();
                            oFormAdminMenu.UserID = userID;
                            oFormAdminMenu.Show();
                            this.Hide();
                        }
                       
                        else if (oMASAUser.Description.Equals("Spec System"))
                        {
                            FormSpecSystemMenu oFormSpecSystemMenu = new FormSpecSystemMenu();
                            oFormSpecSystemMenu.UserID = userID;
                            oFormSpecSystemMenu.Show();
                            this.Hide();
                        }
                        else if (oMASAUser.Description.Equals("PPIC"))
                        {
                            FormPPICMenu oFormPPICMenu = new FormPPICMenu();
                            oFormPPICMenu.UserID = userID;
                            oFormPPICMenu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Iki Ana seng Error loh");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password Yang Anda Masukan SALAH , Periksa Kembali Password Anda !!", "Password Salah", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPasswords.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("UserID Anda Tidak Terdaftar , Periksa Kembali UserID Anda Atau Hubungi Admin Extruder Management System !!", "Error User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserID.Clear();
                    txtPasswords.Clear();
                    txtUserID.Focus();
                }
            }

        }

        private string DomainName
        {
            get
            {
                return ConfigurationManager.AppSettings["DomainName"];
            }
        }

        private bool IsUserActive(string userID)
        {
            MASAUser oMASAUser = new MASAUser_Facade().getMASAUserById(DomainName + "/" + userID);
            if (oMASAUser != null)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        private bool verifycationUser(string userID, string pass)
        {
            MASAUser oMASAUser = new MASAUser_Facade().getMASAUserById(ConfigurationManager.AppSettings["DomainName"].ToString() + "/" + userID);
            string encryptPass = new MASAUser_Facade().getEncrypt(pass);
            return oMASAUser.Passwords.Equals(encryptPass);
        }
    }
}
