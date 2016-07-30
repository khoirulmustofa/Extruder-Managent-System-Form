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
using ExtruderManagementSystem_UI.Admin;
using Microsoft.Reporting.WinForms;

namespace ExtruderManagementSystem_UI.Report
{
    public partial class FormReportUsedCoumpoundTread : Form
    {
        public string UserID;
        private string UserIDFull;
        private string sift = ""; 

        public FormReportUsedCoumpoundTread()
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

        private void FormReportUsedCoumpoundTread_Load(object sender, EventArgs e)
        {
            try
            {
                loadUserInfo();
                if (lblDescription.Text == "PPIC")
                {

                }
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

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblDescription.Text == "Administrator")
                {
                    FormAdminMenu oFormAdminMenu = new FormAdminMenu();
                    oFormAdminMenu.UserID = UserID;
                    oFormAdminMenu.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string kodeSizeTread = txtKode_Size_Tread.Text;
                string dateStar = dtStart.Value.ToString("yyyy-MM-dd");
                string dateFinish = dtFinish.Value.ToString("yyyy-MM-dd");

                DataTable oDataTable = new MASALotAssuranceTreadFront_Facade().getAllUsedCompdTreadAsTableBy(kodeSizeTread, dateStar, dateFinish);
                ReportDataSource oReportDataSource = new ReportDataSource("DataSet1", oDataTable);
                rvUsedCompdTread.LocalReport.ReportPath = "ReportUsedCoumpoundTread.rdlc";
                rvUsedCompdTread.LocalReport.DataSources.Clear();
                rvUsedCompdTread.LocalReport.DataSources.Add(oReportDataSource);
                rvUsedCompdTread.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }
        }
    }
}
