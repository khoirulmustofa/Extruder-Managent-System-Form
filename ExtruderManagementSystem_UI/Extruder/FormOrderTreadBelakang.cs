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

namespace ExtruderManagementSystem_UI.Extruder
{
    public partial class FormOrderTreadBelakang : Form
    {
        public string UserID;
        private string UserIDFull;
        private string sift = "";
        private DataTable oDataTable;
        private DataGridViewButtonColumn btnPilih, btnEdit, btnDelete;

        public FormOrderTreadBelakang()
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

        private void FormOrderTreadBelakang_Load(object sender, EventArgs e)
        {
            try
            {
                loadUserInfo();
                LoadOrderTreadBelakang();
                if (lblDescription.Text == "PPIC")
                {

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }
        }

        private void LoadOrderTreadBelakang()
        {
            if (lblDescription.Text == "Administrator")
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
            gvOrderTreadBelakang.Columns.Clear();
            gvOrderTreadBelakang.DataSource = oDataTable;

            gvOrderTreadBelakang.Columns[0].HeaderText = "KODE ORDER TREAD";
            gvOrderTreadBelakang.Columns[0].Width = 170;
            gvOrderTreadBelakang.Columns[1].HeaderText = "KODE SPEC TREAD";
            gvOrderTreadBelakang.Columns[1].Width = 100;
            gvOrderTreadBelakang.Columns[2].HeaderText = "PREFORMER NO";
            gvOrderTreadBelakang.Columns[2].Width = 100;
            gvOrderTreadBelakang.Columns[3].HeaderText = "INSERT NO";
            gvOrderTreadBelakang.Columns[3].Width = 70;
            gvOrderTreadBelakang.Columns[4].HeaderText = "KODE DIE TREAD";
            gvOrderTreadBelakang.Columns[4].Width = 80;
            gvOrderTreadBelakang.Columns[5].HeaderText = "KODE COMPD";
            gvOrderTreadBelakang.Columns[5].Width = 80;
            gvOrderTreadBelakang.Columns[6].HeaderText = "COMPD CAP";
            gvOrderTreadBelakang.Columns[6].Width = 80;
            gvOrderTreadBelakang.Columns[7].HeaderText = "COMPD BASE";
            gvOrderTreadBelakang.Columns[7].Width = 80;
            gvOrderTreadBelakang.Columns[8].HeaderText = "COMPD WING";
            gvOrderTreadBelakang.Columns[8].Width = 80;
            gvOrderTreadBelakang.Columns[9].HeaderText = "COMPD UNDER TREAD";
            gvOrderTreadBelakang.Columns[9].Width = 80;
            gvOrderTreadBelakang.Columns[10].HeaderText = "MARKING";
            gvOrderTreadBelakang.Columns[10].Width = 80;
            gvOrderTreadBelakang.Columns[11].HeaderText = "PLANING";
            gvOrderTreadBelakang.Columns[11].Width = 80;
            gvOrderTreadBelakang.Columns[12].HeaderText = "KETERANGAN";
            gvOrderTreadBelakang.Columns[12].Width = 100;

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
                gvOrderTreadBelakang.Columns.Add(btnPilih);
                gvOrderTreadBelakang.Columns.Add(btnEdit);
                gvOrderTreadBelakang.Columns.Add(btnDelete);
            }
            else if (lblDescription.Text == "Spec System")
            {
                gvOrderTreadBelakang.Columns.Add(btnEdit);
                gvOrderTreadBelakang.Columns.Add(btnDelete);
            }
            else if (lblDescription.Text == "Extruder  Depan Line 4")
            {
                gvOrderTreadBelakang.Columns.Add(btnPilih);
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

        private void gvOrderTreadBelakang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int pilihBaris = int.Parse(e.RowIndex.ToString());
                string kodeOrderTread = gvOrderTreadBelakang[0, pilihBaris].Value.ToString();
                string KodeSpecTread = gvOrderTreadBelakang[1, pilihBaris].Value.ToString();
                if (gvOrderTreadBelakang.Columns[e.ColumnIndex] == btnPilih && pilihBaris >= 0)
                {
                    bool dialogPilih = MessageBox.Show("Apakah Anda Akan Yakin Melilih Order Tread " + kodeOrderTread, "PILIH ORDER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                    if (dialogPilih)
                    {
                        FormSpecDanLotAssuraceTreadBelakang oFormSpecDanLotAssuraceTreadBelakang = new FormSpecDanLotAssuraceTreadBelakang();
                        oFormSpecDanLotAssuraceTreadBelakang.UserID = UserID;
                        oFormSpecDanLotAssuraceTreadBelakang.kodeOrderTread = kodeOrderTread;
                        oFormSpecDanLotAssuraceTreadBelakang.KodeSpecTread = KodeSpecTread;
                        oFormSpecDanLotAssuraceTreadBelakang.Show();
                        this.Hide();
                    }
                }
                else if (gvOrderTreadBelakang.Columns[e.ColumnIndex] == btnEdit && pilihBaris >= 0)
                {
                    FormSpecDanLotAssuraceTreadDepan FormSpecDanLotAssuraceTreadDepan = new FormSpecDanLotAssuraceTreadDepan();
                    FormSpecDanLotAssuraceTreadDepan.UserID = UserID;
                    FormSpecDanLotAssuraceTreadDepan.KodeOrderTread = kodeOrderTread;
                    FormSpecDanLotAssuraceTreadDepan.Show();
                }
                else if (gvOrderTreadBelakang.Columns[e.ColumnIndex] == btnPilih && pilihBaris >= 0)
                {
                    bool dialogPilih = MessageBox.Show("Apakah Anda Akan Yakin Menghapus Oreder Tread " + kodeOrderTread, "PILIH ORDER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                    if (dialogPilih)
                    {
                        FormSpecDanLotAssuraceTreadDepan FormSpecDanLotAssuraceTreadDepan = new FormSpecDanLotAssuraceTreadDepan();
                        FormSpecDanLotAssuraceTreadDepan.UserID = UserID;
                        FormSpecDanLotAssuraceTreadDepan.KodeOrderTread = kodeOrderTread;
                        FormSpecDanLotAssuraceTreadDepan.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }
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
    }
}
