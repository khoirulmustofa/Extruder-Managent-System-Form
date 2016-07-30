using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using ExtruderManagementSystem_Entity;
using ExtruderManagementSystem_Facade;
using ExtruderManagementSystem_UI.Extruder;

namespace ExtruderManagementSystem_UI.PPIC
{
    public partial class FormPPICMenu : Form
    {
        public string UserID;
        private string UserIDFull;
        private string sift = "";

        public FormPPICMenu()
        {
            InitializeComponent();
        }

        private string DomainName
        {
            get
            {
                return ConfigurationManager.AppSettings["DomainName"];
            }
        }

        private void FormPPICMenu_Load(object sender, EventArgs e)
        {
            try
            {
                loadUserInfo();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }
        }
        private void loadUserInfo()
        {
            MASAUser oMASAUser = new MASAUser_Facade().getMASAUserById(DomainName + "/" + UserID);
            lblUserName.Text = oMASAUser.UserName.ToUpper();
            lblDescription.Text = oMASAUser.Description;
            UserIDFull = oMASAUser.UserID;

            int jam = Convert.ToInt32(DateTime.Now.Hour.ToString());

            if (jam > 6 && jam < 15)
            {
                sift = "1";
            }
            else if (jam > 14 && jam < 23)
            {
                sift = "2";
            }
            else if (jam > 22 && jam < 24)
            {
                sift = "3";
            }
            else if (jam >= 0 && jam < 7)
            {
                sift = "3";
            }
            else
            {
                sift = "Sift Salah";
            }


            lblSiftGroup.Text = sift + oMASAUser.Group;
        }

        private void btnOrderTread_Click(object sender, EventArgs e)
        {
            try
            {
                FormOrderTreadDepan oFormOrderTreadDepan = new FormOrderTreadDepan();
                oFormOrderTreadDepan.userID = UserID;
                oFormOrderTreadDepan.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }

        }

    }
}
