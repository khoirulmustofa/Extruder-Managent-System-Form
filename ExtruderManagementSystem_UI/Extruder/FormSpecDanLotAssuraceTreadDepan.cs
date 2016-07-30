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
using System.IO;

namespace ExtruderManagementSystem_UI.Extruder
{

    public partial class FormSpecDanLotAssuraceTreadDepan : Form
    {
        public string UserID, KodeOrderTread, KodeSpecTread;
        private string UserIDFull;
        private string machine = "";
        private string kodeStampMachine = "";
        private string sift = "";

        public FormSpecDanLotAssuraceTreadDepan()
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

        private void FormSpecDanLotAssuraceTreadDepan_Load(object sender, EventArgs e)
        {
            try
            {
                loadUserInfo();
                LoadSpecTreadByKodeSpecTread();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }
        }

        private void LoadSpecTreadByKodeSpecTread()
        {
            DataTable oDataTable = new MASASpecTread_Facade().getSpecTreadDepanByKodeSpecTread(KodeSpecTread);

            string subKodeDie = oDataTable.Rows[0].ItemArray[5].ToString().Substring(0, 1);

            #region subKodeDie
            if (subKodeDie == "A")
            {
                machine = "EXTRUDER LINE 1";
                kodeStampMachine = "1";
            }
            else if (subKodeDie == "B")
            {
                machine = "EXTRUDER LINE 2";
                kodeStampMachine = "2";
            }
            else if (subKodeDie == "C")
            {
                machine = "EXTRUDER LINE 3";
                kodeStampMachine = "3";
            }
            else if (subKodeDie == "E")
            {
                machine = "EXTRUDER LINE 4";
                kodeStampMachine = "4";
            }
            else if (subKodeDie == "F")
            {
                machine = "EXTRUDER LINE 5";
                kodeStampMachine = "5";
            }
            else if (subKodeDie == "G")
            {
                machine = "EXTRUDER LINE 6";
                kodeStampMachine = "6";
            }
            string kodeCompd = oDataTable.Rows[0].ItemArray[8].ToString();
            string tanggal = DateTime.Now.Day.ToString();
            string bulan = DateTime.Now.Month.ToString();
            string kodeSize = oDataTable.Rows[0].ItemArray[1].ToString();

            lblKode_Order_Tread.Text = KodeOrderTread;
            lblKode_Spec_Tread.Text = oDataTable.Rows[0].ItemArray[0].ToString();
            lblKode_Size_Tread.Text = oDataTable.Rows[0].ItemArray[1].ToString();
            lblSize.Text = oDataTable.Rows[0].ItemArray[2].ToString();
            lblPattren.Text = oDataTable.Rows[0].ItemArray[3].ToString();
            lblBrand.Text = oDataTable.Rows[0].ItemArray[4].ToString();
            lblKode_Die_Tread.Text = oDataTable.Rows[0].ItemArray[5].ToString();
            lblPreformer_No.Text = oDataTable.Rows[0].ItemArray[6].ToString();
            lblInsert_No.Text = oDataTable.Rows[0].ItemArray[7].ToString();
            lblKode_Compd.Text = oDataTable.Rows[0].ItemArray[8].ToString();
            lblCompd_Cap.Text = oDataTable.Rows[0].ItemArray[9].ToString();
            lblCompd_Base.Text = oDataTable.Rows[0].ItemArray[10].ToString();
            lblCompd_Wing.Text = oDataTable.Rows[0].ItemArray[11].ToString();
            lblCompd_Under_Tread.Text = oDataTable.Rows[0].ItemArray[12].ToString();
            lblSpeed_Screw_Cap.Text = oDataTable.Rows[0].ItemArray[13].ToString();
            lblSpeed_Screw_Base.Text = oDataTable.Rows[0].ItemArray[14].ToString();
            lblSpeed_Screw_Wing.Text = oDataTable.Rows[0].ItemArray[15].ToString();
            lblSpeed_Screw_Undet_Tread.Text = oDataTable.Rows[0].ItemArray[16].ToString();
            lblSpeed_Line.Text = oDataTable.Rows[0].ItemArray[17].ToString();
            lblRunning_Scalle_1.Text = oDataTable.Rows[0].ItemArray[18].ToString();
            lblTotal_Width_Setting.Text = oDataTable.Rows[0].ItemArray[19].ToString();
            lblTotal_Width.Text = oDataTable.Rows[0].ItemArray[20].ToString();
            lblCushion_Width.Text = oDataTable.Rows[0].ItemArray[21].ToString();
            lblKode_Stamp_Tread.Text = kodeStampMachine + " " + kodeCompd + " " + sift + " " + tanggal + " " + bulan + " " + kodeSize;
            lblMachineExtruder.Text = machine;
            lblMaxTemperatur.Text = "120";


            pbGambar_Profile_Line_Dies.Image = null;
            if (oDataTable.Rows[0].ItemArray[22] != System.DBNull.Value)
            {
                byte[] photo_aray = (byte[])oDataTable.Rows[0].ItemArray[22];
                MemoryStream ms = new MemoryStream(photo_aray);
                pbGambar_Profile_Line_Dies.Image = Image.FromStream(ms);
            }
            #endregion
            //untuk cek sift
            //kodeStampMachine;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessSave();
            }
            catch (Exception ex) { }
        }

        private void ProcessSave()
        {
            MASALotAssuranceTreadFront oMASALotAssuranceTreadFront = new MASALotAssuranceTreadFront();
            oMASALotAssuranceTreadFront.Kode_Lot_Assurance_Front = lblKode_Spec_Tread.Text + "-" + DateTime.Now.ToString("ddMMyyyy") + "-" + lblSiftGroup.Text;
            oMASALotAssuranceTreadFront.Kode_Order_Tread = lblKode_Order_Tread.Text;
            oMASALotAssuranceTreadFront.Kode_Spec_Tread = lblKode_Spec_Tread.Text;
            oMASALotAssuranceTreadFront.Kode_Size_Tread = lblKode_Size_Tread.Text;
            oMASALotAssuranceTreadFront.Kode_Die_Tread = lblKode_Die_Tread.Text;
            oMASALotAssuranceTreadFront.Kode_Die_Tread_Act = lblKode_Die_Tread.Text;
            oMASALotAssuranceTreadFront.Machine = lblMachineExtruder.Text;
            oMASALotAssuranceTreadFront.Preformer_No = lblPreformer_No.Text;
            oMASALotAssuranceTreadFront.Preformer_No_Act = lblPreformer_No.Text;
            oMASALotAssuranceTreadFront.Insert_No = lblInsert_No.Text;
            oMASALotAssuranceTreadFront.Insert_No_Act = lblInsert_No.Text;
            oMASALotAssuranceTreadFront.Kode_Compd = lblKode_Compd.Text;
            oMASALotAssuranceTreadFront.Kode_Compd_Act = lblKode_Compd.Text;
            oMASALotAssuranceTreadFront.Kode_Stamp_Tread = lblKode_Stamp_Tread.Text;
            oMASALotAssuranceTreadFront.Kode_Stamp_Tread_Act = lblKode_Stamp_Tread.Text;
            oMASALotAssuranceTreadFront.Compd_Cap = lblCompd_Cap.Text;
            oMASALotAssuranceTreadFront.Compd_Cap_FM = txtCompd_Cap_FM.Text;
            oMASALotAssuranceTreadFront.Compd_Cap_RT = txtCompd_Cap_RT.Text;
            oMASALotAssuranceTreadFront.Compd_Base = lblCompd_Base.Text;
            oMASALotAssuranceTreadFront.Compd_Base_FM = txtCompd_Base_FM.Text;
            oMASALotAssuranceTreadFront.Compd_Base_RT = txtCompd_Base_RT.Text;
            oMASALotAssuranceTreadFront.Compd_Wing = lblCompd_Wing.Text;
            oMASALotAssuranceTreadFront.Compd_Wing_FM = txtCompd_Wing_FM.Text;
            oMASALotAssuranceTreadFront.Compd_Wing_RT = txtCompd_Wing_RT.Text;
            oMASALotAssuranceTreadFront.Compd_Under_Tread = lblCompd_Under_Tread.Text;
            oMASALotAssuranceTreadFront.Compd_Under_Tread_FM = txtCompd_Under_Tread_FM.Text;
            oMASALotAssuranceTreadFront.Compd_Under_Tread_RT = txtCompd_Under_Tread_RT.Text;
            oMASALotAssuranceTreadFront.Speed_Screw_Cap = lblSpeed_Screw_Cap.Text;
            oMASALotAssuranceTreadFront.Speed_Screw_Cap_Act = txtSpeed_Screw_Cap_Act.Text;
            oMASALotAssuranceTreadFront.Speed_Screw_Base = lblSpeed_Screw_Base.Text;
            oMASALotAssuranceTreadFront.Speed_Screw_Base_Act = txtSpeed_Screw_Base_Act.Text;
            oMASALotAssuranceTreadFront.Speed_Screw_Wing = lblSpeed_Screw_Wing.Text;
            oMASALotAssuranceTreadFront.Speed_Screw_Wing_Act = txtSpeed_Screw_Wing_Act.Text;
            oMASALotAssuranceTreadFront.Speed_Screw_Undet_Tread = lblSpeed_Screw_Undet_Tread.Text;
            oMASALotAssuranceTreadFront.Speed_Screw_Undet_Tread_Act = txtSpeed_Screw_Undet_Tread_Act.Text;
            oMASALotAssuranceTreadFront.Speed_Line = lblSpeed_Line.Text;
            oMASALotAssuranceTreadFront.Speed_Line_Act = txtSpeed_Line_Act.Text;
            oMASALotAssuranceTreadFront.Total_Width = Convert.ToInt32(lblTotal_Width.Text);
            oMASALotAssuranceTreadFront.Total_Width_Setting = Convert.ToInt32(lblTotal_Width_Setting.Text);
            oMASALotAssuranceTreadFront.Total_Width_Setting_Act = Convert.ToInt32(txtTotal_Width_Setting_Act.Text);
            oMASALotAssuranceTreadFront.Running_Scalle_1 = Convert.ToInt32(lblRunning_Scalle_1.Text);
            oMASALotAssuranceTreadFront.Running_Scalle_1_Act = Convert.ToInt32(txtRunning_Scalle_1_Act.Text);
            oMASALotAssuranceTreadFront.UserID = UserIDFull;
            oMASALotAssuranceTreadFront.Create_Date = DateTime.Now;

            MASALotAssuranceTreadFront_Facade oMASALotAssuranceTreadFront_Facade = new MASALotAssuranceTreadFront_Facade();
            if (oMASALotAssuranceTreadFront_Facade.insertLostAssuranceFornt(oMASALotAssuranceTreadFront))
            {
                MessageBox.Show("HORE BERHSAIL SIMPAN");
            }
            else
            {
                MessageBox.Show("ADUH SON GAGAL SIMPAN");
            }
        }

        private void btnFormOrderTreadDepan_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblDescription.Text == "Administrator")
                {
                    FormOrderTreadDepan oFormOrderTreadDepan = new FormOrderTreadDepan();
                    oFormOrderTreadDepan.userID = UserID;
                    oFormOrderTreadDepan.Show();
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
