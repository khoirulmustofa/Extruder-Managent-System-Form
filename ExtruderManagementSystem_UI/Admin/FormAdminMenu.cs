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
using ExtruderManagementSystem_Entity;
using ExtruderManagementSystem_Facade;
using ExtruderManagementSystem_UI.Extruder;
using ExtruderManagementSystem_UI.Spec_System;
using ExtruderManagementSystem_UI.Report;


namespace ExtruderManagementSystem_UI.Admin
{
    public partial class FormAdminMenu : Form
    {
        public string UserID;
        private string UserIDFull;
        private string sift = "";

        public FormAdminMenu()
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


        private void FormAdminMenu_Load(object sender, EventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
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

        private void btnFormOrderTreadDepan_Click(object sender, EventArgs e)
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
                MessageBox.Show("Eroor Aplikasi Adalah : " + ex.ToString(), "Error Aplikasi");
            }
        }

        private void btnFormMASASpecTread_Click(object sender, EventArgs e)
        {
            try
            {
                FormSpecTread oFormMASASpecTread = new FormSpecTread();
                oFormMASASpecTread.userID = UserID;
                oFormMASASpecTread.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroor Aplikasi Adalah : " + ex.ToString(), "Error Aplikasi");
            }
        }

        private void btnFormOrderTreadBelakang_Click(object sender, EventArgs e)
        {
            try
            {
                FormOrderTreadBelakang oFormOrderTreadBelakang = new FormOrderTreadBelakang();
                oFormOrderTreadBelakang.UserID = UserID;
                oFormOrderTreadBelakang.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroor Aplikasi Adalah : " + ex.ToString(), "Error Aplikasi");
            }
        }

        private void btnFormReportGaugeProfileTread_Click(object sender, EventArgs e)
        {
            try
            {
                FormReportGaugeProfileTread oFormReportGaugeProfileTread = new FormReportGaugeProfileTread();
                oFormReportGaugeProfileTread.UserID = UserID;
                oFormReportGaugeProfileTread.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroor Aplikasi Adalah : " + ex.ToString(), "Error Aplikasi");
            }
        }

        private void btnFormReportStockTread_Click(object sender, EventArgs e)
        {
            try
            {
                FormStockTread oFormStockTread = new FormStockTread();
                oFormStockTread.UserID = UserID;
                oFormStockTread.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroor Aplikasi Adalah : " + ex.ToString(), "Error Aplikasi");
            }
        }

        private void btnFormReportSpeedScrewTread_Click(object sender, EventArgs e)
        {
            try
            {
                FormReportSpeedScrewTread oFormReportSpeedScrewTread = new FormReportSpeedScrewTread();
                oFormReportSpeedScrewTread.UserID = UserID;
                oFormReportSpeedScrewTread.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroor Aplikasi Adalah : " + ex.ToString(), "Error Aplikasi");
            }
        }

        private void btnFormReportUsedCoumpoundTread_Click(object sender, EventArgs e)
        {
            try
            {
                FormReportUsedCoumpoundTread oFormReportUsedCoumpoundTread = new FormReportUsedCoumpoundTread();
                oFormReportUsedCoumpoundTread.UserID = UserID;
                oFormReportUsedCoumpoundTread.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroor Aplikasi Adalah : " + ex.ToString(), "Error Aplikasi");
            }

        }

    }
}
