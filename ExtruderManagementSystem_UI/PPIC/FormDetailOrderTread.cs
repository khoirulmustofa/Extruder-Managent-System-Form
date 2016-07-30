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
using ExtruderManagementSystem_UI.Spec_System;

namespace ExtruderManagementSystem_UI.Extruder
{
    public partial class FormDetailOrderTread : Form
    {
        public string UserID;
        private string UserIDFull;
        private string sift = "";
        public string KodeSpecTread = "";
        public string kodeOrderTread = "";

        public FormDetailOrderTread()
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

        private void FormDetailOrderTread_Load(object sender, EventArgs e)
        {
            try
            {
                loadUserInfo();
                loadKodeSpecTreaD();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }
        }

        private void loadKodeSpecTreaD()
        {
            if (string.IsNullOrEmpty(kodeOrderTread))
            {
                lblKode_Order_Tread_pendamping.Visible = false;
                lblKode_Order_Tread.Visible = false;
                txtKode_Spec_Tread.Text = KodeSpecTread;
            }
            else
            {
                lblKode_Order_Tread.Text = kodeOrderTread;
                btnBrowse.Visible = false;
                MASAOrderTread oMASAOrderTread = new MASAOrderTread_Facade().getOrdertreadBy(kodeOrderTread);
                txtKode_Spec_Tread.Text = oMASAOrderTread.Kode_Spec_Tread;
                txtPlaning.Text = oMASAOrderTread.Planing.ToString();
                cmbKeterangan.Text = oMASAOrderTread.Keterangan;
                if (oMASAOrderTread.Statuss.Equals(1))
                {
                    rbShow.Checked = true;
                }
                else if (oMASAOrderTread.Statuss.Equals(0))
                {
                    rbHide.Checked = true;
                }

            }
        }

        private void loadComboKodeSpecTread()
        {
            DataTable oDataTable = new MASASpecTread_Facade().getAllSpecTreadDepanAsTable();
            //cmbKodeSpecTread.DataSource = oDataTable;
            //cmbKodeSpecTread.DisplayMember = "Kode_Spec_Tread";
            //cmbKodeSpecTread.ValueMember = "Kode_Spec_Tread";
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


        private void processSaveOrderTread()
        {
            string kodeOrder = lblKode_Order_Tread.Text;
            if (string.IsNullOrEmpty(kodeOrder))
            {//Melakuakn Prosses proses Save
                string kodeSpec = txtKode_Spec_Tread.Text;
                string dateNow = DateTime.Now.ToString("ddMMyyyyy");

                MASAOrderTread oMASAOrderTread = new MASAOrderTread();
                oMASAOrderTread.Kode_Order_Tread = kodeSpec + "-" + dateNow;
                oMASAOrderTread.Kode_Spec_Tread = txtKode_Spec_Tread.Text;
                oMASAOrderTread.Planing = Convert.ToInt32(txtPlaning.Text);
                oMASAOrderTread.Keterangan = cmbKeterangan.Text;
                if (rbShow.Checked)
                {
                    oMASAOrderTread.Statuss = 1;
                }
                else if (rbHide.Checked)
                {
                    oMASAOrderTread.Statuss = 0;
                }
                MASAOrderTread_Facade oMASAOrderTread_Facade = new MASAOrderTread_Facade();
                if (oMASAOrderTread_Facade.saveOrderTread(oMASAOrderTread))
                {
                    MessageBox.Show(oMASAOrderTread.Kode_Order_Tread + " Berhasil Di Simpan", "Order Tread", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormOrderTreadDepan oFormOrderTreadDepan = new FormOrderTreadDepan();
                    oFormOrderTreadDepan.userID = UserID;
                    oFormOrderTreadDepan.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(oMASAOrderTread.Kode_Order_Tread + "Gagal Di Simpan", "Order Tread", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {// MELAKUKAN PROSES UPDATE
                MASAOrderTread oMASAOrderTread = new MASAOrderTread();
                oMASAOrderTread.Kode_Order_Tread = lblKode_Order_Tread.Text;
                oMASAOrderTread.Kode_Spec_Tread = txtKode_Spec_Tread.Text;
                oMASAOrderTread.Planing = Convert.ToInt32(txtPlaning.Text);
                oMASAOrderTread.Keterangan = cmbKeterangan.Text;
                if (rbShow.Checked)
                {
                    oMASAOrderTread.Statuss = 1;
                }
                else if (rbHide.Checked)
                {
                    oMASAOrderTread.Statuss = 0;
                }
                MASAOrderTread_Facade oMASAOrderTread_Facade = new MASAOrderTread_Facade();
                if (oMASAOrderTread_Facade.updateOrderTread(oMASAOrderTread))
                {
                    MessageBox.Show(oMASAOrderTread.Kode_Order_Tread + " Berhasil Di Update", "Order Tread", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormOrderTreadDepan oFormOrderTreadDepan = new FormOrderTreadDepan();
                    oFormOrderTreadDepan.userID = UserID;
                    oFormOrderTreadDepan.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(oMASAOrderTread.Kode_Order_Tread + "Gagal Di Update", "Order Tread", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
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
                MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                processSaveOrderTread();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
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
