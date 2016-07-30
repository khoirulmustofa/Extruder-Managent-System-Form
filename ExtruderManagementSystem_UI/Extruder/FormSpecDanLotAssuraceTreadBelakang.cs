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
using System.IO;

namespace ExtruderManagementSystem_UI.Extruder
{
    public partial class FormSpecDanLotAssuraceTreadBelakang : Form
    {
        public string UserID, kodeOrderTread, KodeSpecTread;
        private string UserIDFull;
        private string machine = "";
        private string kodeStampMachine = "";
        private string sift = "";

        private string DomainName
        {
            get
            {
                return ConfigurationManager.AppSettings["DomainName"];
            }
        }

        public FormSpecDanLotAssuraceTreadBelakang()
        {
            InitializeComponent();
        }


        private void FormSpecDanLotAssuraceTreadBelakang_Load(object sender, EventArgs e)
        {
            try
            {
                loadUserInfo();
                LoadSpecTreadBelakangBy(KodeSpecTread);
                if (lblDescription.Text == "PPIC")
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }
        }

        private void LoadSpecTreadBelakangBy(string KodeSpecTread)
        {
            DataTable oDataTable = new MASASpecTread_Facade().getSpecTreadBelakangByKodeSpecTread(KodeSpecTread);

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
            string kodeCompd = new MASASpecTread_Facade().getKodeCompundByKodeSpec(KodeSpecTread);
            string tanggal = DateTime.Now.Day.ToString();
            string bulan = DateTime.Now.Month.ToString();
            string kodeSize = oDataTable.Rows[0].ItemArray[1].ToString();

            lblKode_Order_Tread.Text = kodeOrderTread;
            lblKode_Spec_Tread.Text = oDataTable.Rows[0].ItemArray[0].ToString();
            lblKode_Size_Tread.Text = oDataTable.Rows[0].ItemArray[1].ToString();
            lblSize.Text = oDataTable.Rows[0].ItemArray[2].ToString();
            lblPattren.Text = oDataTable.Rows[0].ItemArray[3].ToString();
            lblBrand.Text = oDataTable.Rows[0].ItemArray[4].ToString();
            lblMachineExtruder.Text = machine;
            lblKode_Die_Tread.Text = oDataTable.Rows[0].ItemArray[5].ToString();
            lblHump_Gauge_Top.Text = oDataTable.Rows[0].ItemArray[6].ToString();
            lblCenter_Gauge.Text = oDataTable.Rows[0].ItemArray[7].ToString();
            lblHump_Gauge_Bot.Text = oDataTable.Rows[0].ItemArray[8].ToString();
            lblHump_Width.Text = oDataTable.Rows[0].ItemArray[9].ToString();
            lblShoulder_Width.Text = oDataTable.Rows[0].ItemArray[10].ToString();
            lblCushion_Width.Text = oDataTable.Rows[0].ItemArray[11].ToString();
            lblTotal_Width.Text = oDataTable.Rows[0].ItemArray[12].ToString();
            lblRunning_Scalle_2.Text = oDataTable.Rows[0].ItemArray[13].ToString();

            lblKode_Stamp_Tread.Text = kodeStampMachine + " " + kodeCompd + " " + sift + " " + tanggal + " " + bulan + " " + kodeSize;
            lblMachineExtruder.Text = machine;
            lblMaxTemperatureWinUp.Text = "36";

            pbGambar_Profile_Line_Dies.Image = null;
            if (oDataTable.Rows[0].ItemArray[14] != System.DBNull.Value)
            {
                byte[] photo_aray = (byte[])oDataTable.Rows[0].ItemArray[14];
                MemoryStream ms = new MemoryStream(photo_aray);
                pbGambar_Profile_Line_Dies.Image = Image.FromStream(ms);
            }
            #endregion
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

                processSaveLotAssuranceBack();
                processSaveStockTread();
                clearTexBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error Aplikasi Sebagai Berikut :" + ex.ToString());
            }
        }

        private void clearTexBox()
        {
            txtHump_Gauge_Top_Act.Text = "";
            txtCenter_Gauge_Act.Text = "";
            txtHump_Gauge_Bot_Act.Text = "";
            txtHump_Width_Act.Text = "";
            txtShoulder_Width_Act.Text = "";
            txtTotal_Width_Act.Text = "";
            txtCushion_Width_Act.Text = "";
            txtMaxTemperatureWinUp_Act.Text = "";
            txtRunning_Scalle_2_Act.Text = "";
            txtRell.Text = "";
            txtPanjang_Tread.Text = "";
            txtNo_Coin_Fifo.Text = "";
            txtHump_Gauge_Top_Act.Focus();
        }

        private void processSaveStockTread()
        {
            MASAStockTread oMASAStockTread = new MASAStockTread();
            oMASAStockTread.Kode_Lot_Assurance_Back = lblKode_Order_Tread.Text + "-" + txtRell.Text;
            oMASAStockTread.No_Coin_Fifo = Convert.ToInt32(txtNo_Coin_Fifo.Text);

            new MASAStockTread_Facade().insertStockTread(oMASAStockTread);
        }

        private void processSaveLotAssuranceBack()
        {
            MASALotAssuranceTreadBack oMASALotAssuranceTreadBack = new MASALotAssuranceTreadBack();
            oMASALotAssuranceTreadBack.Kode_Lot_Assurance_Back = lblKode_Order_Tread.Text + "-" + txtRell.Text;
            oMASALotAssuranceTreadBack.Kode_Order_Tread = lblKode_Order_Tread.Text;
            oMASALotAssuranceTreadBack.Kode_Spec_Tread = lblKode_Spec_Tread.Text;
            oMASALotAssuranceTreadBack.Kode_Size_Tread = lblKode_Size_Tread.Text;
            oMASALotAssuranceTreadBack.Kode_Stamp_Tread = lblKode_Stamp_Tread.Text;
            oMASALotAssuranceTreadBack.Kode_Die_Tread = lblKode_Die_Tread.Text;
            oMASALotAssuranceTreadBack.Machine = lblMachineExtruder.Text;

            if (cbKode_Stamp_Tread_Act.Checked)
            {
                oMASALotAssuranceTreadBack.Kode_Stamp_Tread_Act = lblKode_Stamp_Tread.Text;
            }
            else
            {
                MessageBox.Show("Maaf anda belum melakukan check Kode Stam Tread", "Error Check Stam Tread", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            oMASALotAssuranceTreadBack.Hump_Gauge_Top = lblHump_Gauge_Bot.Text;
            oMASALotAssuranceTreadBack.Hump_Gauge_Top_Act = txtHump_Gauge_Top_Act.Text;
            oMASALotAssuranceTreadBack.Center_Gauge = lblCenter_Gauge.Text;
            oMASALotAssuranceTreadBack.Center_Gauge_Act = txtCenter_Gauge_Act.Text;
            oMASALotAssuranceTreadBack.Hump_Gauge_Bot = lblHump_Gauge_Bot.Text;
            oMASALotAssuranceTreadBack.Hump_Gauge_Bot_Act = txtHump_Gauge_Bot_Act.Text;
            oMASALotAssuranceTreadBack.Hump_Width = Convert.ToInt32(lblHump_Width.Text);
            oMASALotAssuranceTreadBack.Hump_Width_Act = Convert.ToInt32(txtHump_Width_Act.Text);
            oMASALotAssuranceTreadBack.Shoulder_Width = Convert.ToInt32(lblShoulder_Width.Text);
            oMASALotAssuranceTreadBack.Shoulder_Width_Act = Convert.ToInt32(txtShoulder_Width_Act.Text);
            oMASALotAssuranceTreadBack.Cushion_Width = Convert.ToInt32(lblCushion_Width.Text);
            oMASALotAssuranceTreadBack.Cushion_Width_Act = Convert.ToInt32(txtCushion_Width_Act.Text);
            oMASALotAssuranceTreadBack.Total_Width = Convert.ToInt32(lblTotal_Width.Text);
            oMASALotAssuranceTreadBack.Total_Width_Act = Convert.ToInt32(txtTotal_Width_Act.Text);
            oMASALotAssuranceTreadBack.Running_Scalle_2 = Convert.ToInt32(lblRunning_Scalle_2.Text);
            oMASALotAssuranceTreadBack.Running_Scalle_2_Act = Convert.ToInt32(txtRunning_Scalle_2_Act.Text);
            oMASALotAssuranceTreadBack.Panjang_Tread = Convert.ToInt32(txtPanjang_Tread.Text);
            oMASALotAssuranceTreadBack.UserID = UserIDFull;
            oMASALotAssuranceTreadBack.Create_Date = DateTime.Now;
            oMASALotAssuranceTreadBack.Expaired_Date = DateTime.Now.AddDays(Convert.ToInt32(7));
            oMASALotAssuranceTreadBack.Statuss = 1;
            MASALotAssuranceTreadBack_Facade oMASALotAssuranceTreadBack_Facade = new MASALotAssuranceTreadBack_Facade();

            if (oMASALotAssuranceTreadBack_Facade.insertMASALotAssuranceTreadBack(oMASALotAssuranceTreadBack))
            {
                MessageBox.Show("Data " + lblKode_Order_Tread.Text + "-" + txtRell.Text + " Berhasil di Simpan", "Simpan Lot Assurance dan SPC Gauge Tread", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnFormOrderTreadBelakang_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblDescription.Text == "Administrator")
                {
                    FormOrderTreadBelakang oFormOrderTreadBelakang = new FormOrderTreadBelakang();
                    oFormOrderTreadBelakang.UserID = UserID;
                    oFormOrderTreadBelakang.Show();
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
