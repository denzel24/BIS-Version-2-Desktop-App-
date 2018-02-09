using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using BAL;

namespace BIS_Version_2_Desktop_App_.Residence
{
    public partial class frmResApplication : Form
    {
        public frmResApplication()
        {
            InitializeComponent();
        }
        public ResidenceOPR ResOpr = new ResidenceOPR();
        public ResidenceInfo RInfo = new ResidenceInfo();
        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void frmResApplication_Load(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            RInfo.resFullName = txtFname.Text + " " + txtMname.Text + " " + txtLname.Text;
            RInfo.resBdate = Bdate.Text;
            RInfo.resBplace = txtBplace.Text;
            RInfo.resAddress = txtAddress.Text;
            RInfo.resPurok = txtPurok.Text;
            RInfo.resGender = txtGender.Text;
            RInfo.resReligion = txtReligion.Text;
            RInfo.resCitizenship = txtCitizenship.Text;
            RInfo.resCivilStatus = txtCivilStatus.Text;
            RInfo.resBloodType = txtBloodType.Text;
            RInfo.resContact = txtContactNo.Text;
            RInfo.resStartedLiving = dateStarted.Text;
            object Id = ResOpr.InsertResidence(RInfo).ToString();
            resId.Text = Id.ToString();
            if(Id != null)
            {
                MessageBox.Show("Added");
            }
            if(txtVIN.Text != "" || txtPrecinctNo.Text != "" || txtRegAddress.Text != "")
            {
                registeredVoter();
            }
            if(txtSenControlNo.Text != "" || txtSenDateReg.MaskCompleted)
            {
                SeniorCitizen();
            }
            if(txtPWDControlNo.Text != "" || txtPWDDateReg.MaskCompleted || txtDisability.Text != "" || txtCauseDisabilty.Text != "")
            {
                PWD();
            }
        }
        void registeredVoter()
        {
            RInfo.resId = resId.Text;
            RInfo.VIN = txtVIN.Text;
            RInfo.PrecinctNo = txtPrecinctNo.Text;
            RInfo.Address = txtRegAddress.Text;
            int rows = ResOpr.insertRegisteredVoter(RInfo);
        }
        void SeniorCitizen()
        {
            RInfo.resId = resId.Text;
            RInfo.SenControlNo = txtSenControlNo.Text;
            RInfo.dateRegistered = txtSenDateReg.Text;
            int rows = ResOpr.insertSeniorCitizen(RInfo);
        }
        void PWD()
        {
            RInfo.resId = resId.Text;
            RInfo.pwdControlNo = txtPWDControlNo.Text;
            RInfo.dateRegistered = txtPWDDateReg.Text;
            RInfo.disabilityType = txtDisability.Text;
            RInfo.causeOfDisability = txtCauseDisabilty.Text;
            int rows = ResOpr.insertPWD(RInfo);
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtBloodType_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
