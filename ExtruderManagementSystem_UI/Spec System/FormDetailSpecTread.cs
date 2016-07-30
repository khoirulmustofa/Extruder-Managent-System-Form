using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtruderManagementSystem_Entity;
using ExtruderManagementSystem_Facade;

namespace ExtruderManagementSystem_UI.Spec_System
{
    public partial class FormDetailSpecTread : Form
    {
        public string UserID, kodeSpecTread;
        private string UserIDFull;
        private string sift = "";
        private string imageLocation = "";
        public FormDetailSpecTread()
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

        private void FormDetailSpecTread_Load(object sender, EventArgs e)
        {
            try
            {
                loadUserInfo();
                if (!string.IsNullOrEmpty(kodeSpecTread))
                {
                    loadSpecTreadByKodeSpecTread(kodeSpecTread);
                    txtKode_Spec_Tread.Enabled = false;
                    txtKode_Size_Tread.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }
        }

        private void loadSpecTreadByKodeSpecTread(string kodeSpecTread)
        {
            MASASpecTread oMASASpecTread = new MASASpecTread_Facade().getSpecTreadByKodeSpecTread(kodeSpecTread);
            txtKode_Spec_Tread.Text = oMASASpecTread.Kode_Spec_Tread;
            txtKode_Size_Tread.Text = oMASASpecTread.Kode_Size_Tread;
            txtKode_Die_Tread.Text = oMASASpecTread.Kode_Die_Tread;

            txtMarking.Text = oMASASpecTread.Marking;
            txtKode_Compd.Text = oMASASpecTread.Kode_Compd;
            txtCompd_Cap.Text = oMASASpecTread.Compd_Cap;
            txtCompd_Base.Text = oMASASpecTread.Compd_Base;
            txtCompd_Wing.Text = oMASASpecTread.Compd_Wing;
            txtCompd_Under_Tread.Text = oMASASpecTread.Compd_Under_Tread;
            if (oMASASpecTread.Statuss.Equals(1))
            {
                rbAktif.Checked = true;
            }
            else if (oMASASpecTread.Statuss.Equals(0))
            {
                rbNoAktif.Checked = true;
            }

            byte[] gambarArray = (byte[])(oMASASpecTread.Gambar_Profile_Line_Dies);
            if (gambarArray == null)
            {
                pbGambar_Profile_Line_Dies.Image = null;
            }
            else
            {
                MemoryStream oMemoryStream = new MemoryStream(gambarArray);
                pbGambar_Profile_Line_Dies.Image = Image.FromStream(oMemoryStream);
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


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog oOpenFileDialog = new OpenFileDialog();
                oOpenFileDialog.Filter = "PNG Files (*.PNG)|*.PNG|JPG Files (*.jpg)|*.jpg|All Files (*.*)|*.*";
                oOpenFileDialog.Title = "Pilih Gambar Profile Tread";
                if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = oOpenFileDialog.FileName.ToString();
                    pbGambar_Profile_Line_Dies.ImageLocation = imageLocation;
                }

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
                FormSpecTread oFormSpecTread = new FormSpecTread();
                oFormSpecTread.userID = UserID;
                oFormSpecTread.Show();
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
                MemoryStream oMemoryStream = new MemoryStream();
                pbGambar_Profile_Line_Dies.Image.Save(oMemoryStream, ImageFormat.Png);
                byte[] gambarArray = new byte[oMemoryStream.Length];
                oMemoryStream.Position = 0;
                oMemoryStream.Read(gambarArray, 0, gambarArray.Length);

                MASASpecTread oMASASpecTread = new MASASpecTread();
                oMASASpecTread.Kode_Spec_Tread = txtKode_Spec_Tread.Text;
                oMASASpecTread.Kode_Size_Tread = txtKode_Size_Tread.Text;
                oMASASpecTread.Kode_Die_Tread = txtKode_Die_Tread.Text;
                oMASASpecTread.Gambar_Profile_Line_Dies = gambarArray;
                oMASASpecTread.Marking = txtMarking.Text;
                oMASASpecTread.Kode_Compd = txtKode_Compd.Text;
                oMASASpecTread.Compd_Cap = txtCompd_Cap.Text;
                oMASASpecTread.Compd_Base = txtCompd_Base.Text;
                oMASASpecTread.Compd_Wing = txtCompd_Wing.Text;
                oMASASpecTread.Compd_Under_Tread = txtCompd_Under_Tread.Text;
                if (rbAktif.Checked)
                {
                    oMASASpecTread.Statuss = 1;
                }
                else
                {
                    oMASASpecTread.Statuss = 0;
                }
                MASASpecTread_Facade oMASASpecTread_Facade = new MASASpecTread_Facade();
                if (string.IsNullOrEmpty(kodeSpecTread))
                {
                    if (oMASASpecTread_Facade.insertSpecTread(oMASASpecTread))
                    {
                        MessageBox.Show("Data Berhasil di simpan");
                        FormSpecTread oFormSpecTread = new FormSpecTread();
                        oFormSpecTread.userID = UserID;
                        oFormSpecTread.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Data GAGAL di simpan");
                    }
                }
                else
                {
                    if (oMASASpecTread_Facade.updateSpecTread(oMASASpecTread))
                    {
                        MessageBox.Show("Data Berhasil di Update");
                        this.Hide();
                        FormSpecTread oFormSpecTread = new FormSpecTread();
                        oFormSpecTread.userID = UserID;
                        oFormSpecTread.Show();
                    }
                    else
                    {
                        MessageBox.Show("Data GAGAL di Update");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }
        }

    }
}
