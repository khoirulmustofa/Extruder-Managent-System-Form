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
using ExtruderManagementSystem_UI.Extruder;
using ExtruderManagementSystem_UI.PPIC;

namespace ExtruderManagementSystem_UI.Spec_System
{
    public partial class FormSpecTread : Form
    {
        public string userID;
        private string userIDFull;
        private string sift = "";

        private DataGridViewButtonColumn btnPilih, btnEdit, btnDelete;

        public FormSpecTread()
        {
            InitializeComponent();
        }

        private void FormMASASpecTread_Load(object sender, EventArgs e)
        {
            try
            {
                loadUserInfo();
                loadSpecTread();
                authLevel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }
        }

        private void authLevel()
        {
            if (lblDescription.Text.Equals("PPIC"))
            {
                btnAdd.Visible = false;
                btnHome.Visible = false;
            }
        }

        private void loadSpecTread()
        {
            DataTable oDataTable = new MASASpecTread_Facade().getAllSpecTreadDepanAsTable();
            gvSpecTread.DataSource = null;
            gvSpecTread.Columns.Clear();
            gvSpecTread.DataSource = oDataTable;
            gvSpecTread.Columns[0].HeaderText = "KODE SPEC TREAD";
            gvSpecTread.Columns[0].Width = 170;
            gvSpecTread.Columns[1].HeaderText = "KODE SIZE TREAD";
            gvSpecTread.Columns[1].Width = 100;
            gvSpecTread.Columns[2].HeaderText = "KODE DIE TREAD";
            gvSpecTread.Columns[2].Width = 100;
            gvSpecTread.Columns[3].HeaderText = "MARKING";
            gvSpecTread.Columns[3].Width = 70;
            gvSpecTread.Columns[4].HeaderText = "KODE COMPD";
            gvSpecTread.Columns[4].Width = 80;
            gvSpecTread.Columns[5].HeaderText = "COMPD CAP";
            gvSpecTread.Columns[5].Width = 80;
            gvSpecTread.Columns[6].HeaderText = "COMPD BASE";
            gvSpecTread.Columns[6].Width = 80;
            gvSpecTread.Columns[7].HeaderText = "COMPD WING";
            gvSpecTread.Columns[7].Width = 80;
            gvSpecTread.Columns[8].HeaderText = "COMPD UNDER TREAD";
            gvSpecTread.Columns[8].Width = 80;

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
                gvSpecTread.Columns.Add(btnPilih);
                gvSpecTread.Columns.Add(btnEdit);
                gvSpecTread.Columns.Add(btnDelete);
            }
            else if (lblDescription.Text == "Spec System")
            {
                gvSpecTread.Columns.Add(btnEdit);
                gvSpecTread.Columns.Add(btnDelete);
            }
            else if (lblDescription.Text == "PPIC")
            {
                gvSpecTread.Columns.Add(btnPilih);
            }
        }

        private string DomainName
        {
            get
            {
                return ConfigurationManager.AppSettings["DomainName"];
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


        private void btnRefress_Click(object sender, EventArgs e)
        {
            try
            {
                loadSpecTread();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
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
                else if (lblDescription.Text == "Spec System")
                {
                    FormSpecSystemMenu oFormSpecSystemMenu = new FormSpecSystemMenu();
                    oFormSpecSystemMenu.UserID = userID;
                    oFormSpecSystemMenu.Show();
                    this.Hide();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (lblDescription.Text == "Administrator")
                {
                    FormDetailSpecTread oFormDetailSpecTread = new FormDetailSpecTread();
                    oFormDetailSpecTread.UserID = userID;
                    oFormDetailSpecTread.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }
        }

        private void btnSearchByKodeSpec_Click(object sender, EventArgs e)
        {
            try
            {
                string kodeSize = txtKode_Size_Tread.Text;
                if (string.IsNullOrEmpty(kodeSize))
                {
                    loadSpecTread();
                }
                else
                {
                    loadSpecTreadBy(kodeSize);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }
        }

        private void loadSpecTreadBy(string kodeSize)
        {
            DataTable oDataTable = new MASASpecTread_Facade().getAllSpecTreadDepanAsTableBy(kodeSize);
            gvSpecTread.DataSource = null;
            gvSpecTread.Columns.Clear();
            gvSpecTread.DataSource = oDataTable;
            gvSpecTread.Columns[0].HeaderText = "KODE SPEC TREAD";
            gvSpecTread.Columns[0].Width = 170;
            gvSpecTread.Columns[1].HeaderText = "KODE SIZE TREAD";
            gvSpecTread.Columns[1].Width = 100;
            gvSpecTread.Columns[2].HeaderText = "KODE DIE TREAD";
            gvSpecTread.Columns[2].Width = 100;
            gvSpecTread.Columns[3].HeaderText = "MARKING";
            gvSpecTread.Columns[3].Width = 70;
            gvSpecTread.Columns[4].HeaderText = "KODE COMPD";
            gvSpecTread.Columns[4].Width = 80;
            gvSpecTread.Columns[5].HeaderText = "COMPD CAP";
            gvSpecTread.Columns[5].Width = 80;
            gvSpecTread.Columns[6].HeaderText = "COMPD BASE";
            gvSpecTread.Columns[6].Width = 80;
            gvSpecTread.Columns[7].HeaderText = "COMPD WING";
            gvSpecTread.Columns[7].Width = 80;
            gvSpecTread.Columns[8].HeaderText = "COMPD UNDER TREAD";
            gvSpecTread.Columns[8].Width = 80;

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
                gvSpecTread.Columns.Add(btnPilih);
                gvSpecTread.Columns.Add(btnEdit);
                gvSpecTread.Columns.Add(btnDelete);
            }
            else if (lblDescription.Text == "PPIC")
            {
                gvSpecTread.Columns.Add(btnPilih);
            }
            else if (lblDescription.Text == "Spec System")
            {
                gvSpecTread.Columns.Add(btnEdit);
                gvSpecTread.Columns.Add(btnDelete);
            }
        }

        private void gvSpecTread_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int pilihBaris = int.Parse(e.RowIndex.ToString());
                string kodeSpecTread = gvSpecTread[0, pilihBaris].Value.ToString();
                if (gvSpecTread.Columns[e.ColumnIndex] == btnPilih && pilihBaris >= 0)
                {
                    FormDetailOrderTread oFormDetailOrderTread = new FormDetailOrderTread();
                    oFormDetailOrderTread.UserID = userID;
                    oFormDetailOrderTread.KodeSpecTread = kodeSpecTread;
                    oFormDetailOrderTread.Show();
                    this.Hide();
                }
                else if (gvSpecTread.Columns[e.ColumnIndex] == btnEdit && pilihBaris >= 0)
                {
                    FormDetailSpecTread oFormDetailSpecTread = new FormDetailSpecTread();
                    oFormDetailSpecTread.UserID = userID;
                    oFormDetailSpecTread.kodeSpecTread = kodeSpecTread;
                    oFormDetailSpecTread.Show();
                    this.Hide();
                }
                else if (gvSpecTread.Columns[e.ColumnIndex] == btnDelete && pilihBaris >= 0)
                {
                    //bool dialogPilih = MessageBox.Show("Apakah Anda Akan Yakin Menghapus Oreder Tread " + kodeOrderTread, "PILIH ORDER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                    //if (dialogPilih)
                    //{
                    //    new MASAOrderTread_Facade().deleteOrderTread(kodeOrderTread);
                    //    loadOrderTreadDepan();
                    //}
                }
               
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }
        }
    }
}
