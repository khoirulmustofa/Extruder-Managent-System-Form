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
using ExtruderManagementSystem_UI.Admin;
using ExtruderManagementSystem_UI.PPIC;

namespace ExtruderManagementSystem_UI.Extruder
{
    public partial class FormOrderTreadDepan : Form
    {
        public string userID;
        private string userIDFull;
        private string sift = "";

        private DataTable oDataTable;
        private DataGridViewButtonColumn btnPilih, btnEdit, btnDelete;

        public FormOrderTreadDepan()
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

        private void FormOrderTreadDepan_Load(object sender, EventArgs e)
        {
            try
            {
                loadUserInfo();
                loadOrderTreadDepan();
                if (lblDescription.Text == "PPIC")
                {

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }
        }

        private void loadUserInfo()
        {
            MASAUser oMASAUser = new MASAUser_Facade().getMASAUserById(DomainName + "/" + userID);
            lblUserName.Text = oMASAUser.UserName.ToUpper();
            lblDescription.Text = oMASAUser.Description;
            userIDFull = oMASAUser.UserID;

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
                    oFormAdminMenu.UserID = userID;
                    oFormAdminMenu.Show();
                    this.Hide();
                }
                else if (lblDescription.Text == "PPIC")
                {
                    FormPPICMenu oFormPPICMenu = new FormPPICMenu();
                    oFormPPICMenu.UserID = userID;
                    oFormPPICMenu.Show();
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
                loadOrderTreadDepan();
            }
            catch (Exception ex) { }
        }

        private void loadOrderTreadDepan()
        {
            if (lblDescription.Text == "Administrator")
            {
                oDataTable = new MASAOrderTread_Facade().getOrderTreadDepanAsTabel();
            }
            else if (lblDescription.Text == "PPIC")
            {
                oDataTable = new MASAOrderTread_Facade().getOrderTreadDepanAsTabel();
            }
            else if (lblDescription.Text == "Extruder  Depan Line 4")
            {
                string line4 = "EP";
                oDataTable = new MASAOrderTread_Facade().getViewOrderTreadDepanAsTabelByline(line4);
            }
            else if (lblDescription.Text == "Extruder  Depan Line 2")
            {
                string line2 = "BP";
                oDataTable = new MASAOrderTread_Facade().getViewOrderTreadDepanAsTabelByline(line2);
            }
            gvOrderTreadDepan.Columns.Clear();
            gvOrderTreadDepan.DataSource = oDataTable;

            gvOrderTreadDepan.Columns[0].HeaderText = "KODE ORDER TREAD";
            gvOrderTreadDepan.Columns[0].Width = 170;
            gvOrderTreadDepan.Columns[1].HeaderText = "KODE SPEC TREAD";
            gvOrderTreadDepan.Columns[1].Width = 100;
            gvOrderTreadDepan.Columns[2].HeaderText = "PREFORMER NO";
            gvOrderTreadDepan.Columns[2].Width = 100;
            gvOrderTreadDepan.Columns[3].HeaderText = "INSERT NO";
            gvOrderTreadDepan.Columns[3].Width = 70;
            gvOrderTreadDepan.Columns[4].HeaderText = "KODE DIE TREAD";
            gvOrderTreadDepan.Columns[4].Width = 80;
            gvOrderTreadDepan.Columns[5].HeaderText = "KODE COMPD";
            gvOrderTreadDepan.Columns[5].Width = 80;
            gvOrderTreadDepan.Columns[6].HeaderText = "COMPD CAP";
            gvOrderTreadDepan.Columns[6].Width = 80;
            gvOrderTreadDepan.Columns[7].HeaderText = "COMPD BASE";
            gvOrderTreadDepan.Columns[7].Width = 80;
            gvOrderTreadDepan.Columns[8].HeaderText = "COMPD WING";
            gvOrderTreadDepan.Columns[8].Width = 80;
            gvOrderTreadDepan.Columns[9].HeaderText = "COMPD UNDER TREAD";
            gvOrderTreadDepan.Columns[9].Width = 80;
            gvOrderTreadDepan.Columns[10].HeaderText = "MARKING";
            gvOrderTreadDepan.Columns[10].Width = 80;
            gvOrderTreadDepan.Columns[11].HeaderText = "PLANING";
            gvOrderTreadDepan.Columns[11].Width = 80;
            gvOrderTreadDepan.Columns[12].HeaderText = "KETERANGAN";
            gvOrderTreadDepan.Columns[12].Width = 100;

            btnPilih = new DataGridViewButtonColumn();
            btnPilih.HeaderText = "AKSI";
            btnPilih.UseColumnTextForButtonValue = true;
            btnPilih.Text = "PILIH";
            btnPilih.Width = 70;

            btnEdit = new DataGridViewButtonColumn();
            btnEdit.UseColumnTextForButtonValue = true;
            btnEdit.Text = "EDIT";
            btnEdit.Width = 50;

            btnDelete = new DataGridViewButtonColumn();
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.Text = "HAPUS";
            btnDelete.Width = 60;

            if (lblDescription.Text == "Administrator")
            {
                gvOrderTreadDepan.Columns.Add(btnPilih);
                gvOrderTreadDepan.Columns.Add(btnEdit);
                gvOrderTreadDepan.Columns.Add(btnDelete);
            }
            else if (lblDescription.Text == "PPIC")
            {
                gvOrderTreadDepan.Columns.Add(btnEdit);
                gvOrderTreadDepan.Columns.Add(btnDelete);
            }
            else if (lblDescription.Text == "Extruder  Depan Line 4")
            {
                gvOrderTreadDepan.Columns.Add(btnPilih);
            }
        }

        private void gvOrderTreadDepan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int pilihBaris = int.Parse(e.RowIndex.ToString());
                string kodeOrderTread = gvOrderTreadDepan[0, pilihBaris].Value.ToString();
                string kodeSpecTread = gvOrderTreadDepan[1, pilihBaris].Value.ToString();
                if (gvOrderTreadDepan.Columns[e.ColumnIndex] == btnPilih && pilihBaris >= 0)
                {
                    bool dialogPilih = MessageBox.Show("Apakah Anda Akan Yakin Melilih Order Tread " + kodeOrderTread, "PILIH ORDER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                    if (dialogPilih)
                    {
                        //MessageBox.Show(kodeSpecTread);
                        FormSpecDanLotAssuraceTreadDepan oFormSpecDanLotAssuraceTreadDepan = new FormSpecDanLotAssuraceTreadDepan();
                        oFormSpecDanLotAssuraceTreadDepan.UserID = userID;
                        oFormSpecDanLotAssuraceTreadDepan.KodeOrderTread = kodeOrderTread;
                        oFormSpecDanLotAssuraceTreadDepan.KodeSpecTread = kodeSpecTread;
                        oFormSpecDanLotAssuraceTreadDepan.Show();
                        this.Hide();
                    }
                }
                else if (gvOrderTreadDepan.Columns[e.ColumnIndex] == btnEdit && pilihBaris >= 0)
                {
                    FormDetailOrderTread oFormDetailOrderTread = new FormDetailOrderTread();
                    oFormDetailOrderTread.UserID = userID;
                    oFormDetailOrderTread.kodeOrderTread = kodeOrderTread;
                    oFormDetailOrderTread.KodeSpecTread = kodeSpecTread;
                    oFormDetailOrderTread.Show();
                    this.Hide();
                }
                else if (gvOrderTreadDepan.Columns[e.ColumnIndex] == btnDelete && pilihBaris >= 0)
                {
                    bool dialogPilih = MessageBox.Show("Apakah Anda Akan Yakin Menghapus Oreder Tread " + kodeOrderTread, "PILIH ORDER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                    if (dialogPilih)
                    {
                        new MASAOrderTread_Facade().deleteOrderTread(kodeOrderTread);
                        loadOrderTreadDepan();
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }
        }

        private void btnAddorderTread_Click(object sender, EventArgs e)
        {
            try
            {
                FormDetailOrderTread oFormDetailOrderTread = new FormDetailOrderTread();
                oFormDetailOrderTread.UserID = userID;
                oFormDetailOrderTread.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }
        }
    }
}
