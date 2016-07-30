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

namespace ExtruderManagementSystem_UI.Extruder
{
    public partial class FormStockTread : Form
    {
        public string UserID;
        private string UserIDFull;
        private string sift = "";

        private DataTable oDataTable;
        private DataGridViewButtonColumn btnPilih, btnEdit, btnDelete;


        public FormStockTread()
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

        private void FormStockTread_Load(object sender, EventArgs e)
        {
            try
            {
                loadUserInfo();
                loadStockTread();
                if (lblDescription.Text == "PPIC")
                {

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }
        }

        private void loadStockTread()
        {
            oDataTable = new MASAStockTread_Facade().getViewStokTreadAll();
            gvStockTread.Columns.Clear();
            gvStockTread.DataSource = oDataTable;

            gvStockTread.Columns[0].HeaderText = "KODE STOCK TREAD";
            gvStockTread.Columns[0].Width = 180;
            gvStockTread.Columns[1].HeaderText = "KODE SIZE TREAD";
            gvStockTread.Columns[1].Width = 130;
            gvStockTread.Columns[2].HeaderText = "MACHINE";
            gvStockTread.Columns[2].Width = 130;
            gvStockTread.Columns[3].HeaderText = "PANJANG TREAD";
            gvStockTread.Columns[3].Width = 90;
            gvStockTread.Columns[4].HeaderText = "NO COIN FIFO";
            gvStockTread.Columns[4].Width = 120;
            gvStockTread.Columns[5].HeaderText = "CREATE DATE";
            gvStockTread.Columns[5].Width = 150;
            gvStockTread.Columns[6].HeaderText = "EXPAIRED DATE";
            gvStockTread.Columns[6].Width = 150;

            btnPilih = new DataGridViewButtonColumn();
            btnPilih.HeaderText = "AKSI";
            btnPilih.UseColumnTextForButtonValue = true;
            btnPilih.Text = "PILIH";
            btnPilih.Width = 70;

            if (lblDescription.Text == "Administrator")
            {
                gvStockTread.Columns.Add(btnPilih);
            }
            else if (lblDescription.Text == "Extruder  Depan Line 4")
            {
                gvStockTread.Columns.Add(btnPilih);
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

        private void btnHomeMenu_Click(object sender, EventArgs e)
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

        private void btnRefress_Click(object sender, EventArgs e)
        {
            try
            {
                loadStockTread();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }

        }

        private void gvStockTread_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int pilihBaris = int.Parse(e.RowIndex.ToString());
                string kodeStockTread = gvStockTread[0, pilihBaris].Value.ToString();
                string kodeSizeTread = gvStockTread[1, pilihBaris].Value.ToString();
                if (gvStockTread.Columns[e.ColumnIndex] == btnPilih && pilihBaris >= 0)
                {
                    bool dialogPilih = MessageBox.Show("Apakah Anda Akan Yakin Melilih Kode Size ini " + kodeSizeTread, "PILIH STOCK TREAD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                    if (dialogPilih)
                    {
                        new MASAStockTread_Facade().deleteStockTread(kodeStockTread);
                    }
                }
                loadStockTread();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }
        }

    }
}
