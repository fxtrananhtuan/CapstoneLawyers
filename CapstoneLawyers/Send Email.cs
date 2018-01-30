using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace CapstoneLawyers
{
    public partial class Send_Email : Form
    {
        public Send_Email()
        {
            InitializeComponent();
        }

        BUS_OpenOutLook _BUS_Open = new BUS_OpenOutLook();
        

        private void cmd_open_Click(object sender, EventArgs e)
        {
            _BUS_Open.OpenOutLook("\n Please find the attached file", "Capstone Lawyers", GlobalVariable.Global_Customer.Email,GlobalVariable.LocationForPayment,GlobalVariable.Global_Customer.Matter_ID);

        }

        private void ckb_Cost_CheckedChanged(object sender, EventArgs e)
        {
            if(ckb_Cost.Checked)
            {
                BUS.BUS_OpenOutLook.CostAgreement = true;
            }
            else
            {
                BUS.BUS_OpenOutLook.CostAgreement = false;
            }
        }

        private void ckb_Eng_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Eng.Checked)
            {
                BUS.BUS_OpenOutLook.EngagementLetter = true;
            }
            else
            {
                BUS.BUS_OpenOutLook.EngagementLetter = false;
            }
        }

        private void ckb_tax_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_tax.Checked)
            {
                BUS.BUS_OpenOutLook.TaxInvoice = true;
            }
            else
                BUS.BUS_OpenOutLook.TaxInvoice = false;
        }

        private void ckb_Dis_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Dis.Checked)
            {
                BUS.BUS_OpenOutLook.DisclosureStatement = true;
            }
            else
                BUS.BUS_OpenOutLook.DisclosureStatement = false;

        }

        private void cbk_Payment_CheckedChanged(object sender, EventArgs e)
        {
            if (cbk_Payment.Checked)
            {
                BUS.BUS_OpenOutLook.PaymentReceipt = true;
            }
            else
                BUS.BUS_OpenOutLook.PaymentReceipt = false;

        }
    }
}
