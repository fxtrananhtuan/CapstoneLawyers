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
using DTO;

namespace CapstoneLawyers
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        BUS_Payment Bus_pay = new BUS_Payment();
        DTO_Payment DTO_pay = new DTO_Payment();
        BUS_Letter Bus_letter = new BUS_Letter();
        DataTable info = new DataTable();

        private void Payment_Load(object sender, EventArgs e)
        {
            info = Bus_pay.Load(GlobalVariable.Global_Customer.Matter_ID);

            if(info.Rows.Count<1)
            {
                cmd_edit.Text = "Create";
            }
            else
            {
                cmd_edit.Text = "Edit";
                txt_Payment.Text = info.Rows[0][4].ToString();
                txt_GST.Text = info.Rows[0][3].ToString();
                txt_Balance.Text = info.Rows[0][5].ToString();
                txt_Amount.Text = info.Rows[0][2].ToString();
                txt_Description.Text = info.Rows[0][6].ToString();
                txt_ReceiptNo.Text = info.Rows[0][1].ToString();
            }
            if(cmd_edit.Text=="Create")
            {
                txt_Amount.ReadOnly = true;
                txt_Balance.ReadOnly = true;
                txt_GST.ReadOnly = true;
                txt_Payment.ReadOnly = true;
                txt_ReceiptNo.ReadOnly = true;
                txt_Description.ReadOnly = true;
                cmd_edit.Enabled = true;
                cmd_Payment.Enabled = false;
                cmd_save.Enabled = false;
            }
            else
            {
                txt_Description.ReadOnly = true;
                txt_Amount.ReadOnly = true;
                txt_Balance.ReadOnly = true;
                txt_GST.ReadOnly = true;
                txt_Payment.ReadOnly = true;
                txt_ReceiptNo.ReadOnly = true;
                cmd_edit.Enabled = true;
                cmd_Payment.Enabled = true;
                cmd_save.Enabled = false;
            }
        }

        Boolean flag = true;
        private void cmd_edit_Click(object sender, EventArgs e)
        {
            if(cmd_edit.Text=="Create")
            {
                flag = true;
                txt_ReceiptNo.Text= Bus_pay.CreateID();
                txt_Amount.ReadOnly = false;
                txt_Balance.ReadOnly = false;
                txt_GST.ReadOnly = false;
                txt_Payment.ReadOnly = false;
                txt_Description.ReadOnly = false;
                txt_ReceiptNo.ReadOnly = true;
                txt_Payment.Text = "";
                txt_GST.Text = "";
                txt_Balance.Text = "";
                txt_Amount.Text = "";
                txt_Description.Text = "";
                cmd_edit.Text = "Edit";
                cmd_edit.Enabled = false;
                cmd_Payment.Enabled = false;
                cmd_save.Enabled = true;
            }
            else
            {
                flag = false;
                txt_Amount.ReadOnly = false;
                txt_Balance.ReadOnly = false;
                txt_GST.ReadOnly = false;
                txt_Payment.ReadOnly = false;
                txt_ReceiptNo.ReadOnly = false;
                txt_Description.ReadOnly = false;
                cmd_edit.Enabled = false;
                cmd_Payment.Enabled = false;
                cmd_save.Enabled = true;
            }
        }

        private void cmd_save_Click(object sender, EventArgs e)
        {
            DTO_pay.Amount = Convert.ToDecimal(txt_Amount.Text.Trim());
            DTO_pay.Balance = Convert.ToDecimal(txt_Balance.Text.Trim());
            DTO_pay.GST = Convert.ToDecimal(txt_GST.Text.Trim());
            DTO_pay.Matter_ID = GlobalVariable.Global_Customer.Matter_ID;
            DTO_pay.Receipt_No = txt_ReceiptNo.Text.Trim();
            DTO_pay.Received = Convert.ToDecimal(txt_Payment.Text.Trim());
            DTO_pay.Description = txt_Description.Text.Trim();

            if(flag)
            {
                Bus_pay.Insert(DTO_pay);
                cmd_edit.Enabled = true;
                cmd_Payment.Enabled = true;
                cmd_save.Enabled = false;
                cmd_edit.Text = "Edit";
            }
            else
            {
                Bus_pay.Update(DTO_pay);
                cmd_edit.Enabled = true;
                cmd_Payment.Enabled = true;
                cmd_save.Enabled = false;
                cmd_edit.Text = "Edit";
            }
            info = Bus_pay.Load(GlobalVariable.Global_Customer.Matter_ID);


        }

        private void cmd_Payment_Click(object sender, EventArgs e)
        {
            Bus_letter.Kill_process();
            DTO_Customer _cus = GlobalVariable.Global_Customer;
            Bus_letter.Fill_On_Word(_cus.FirstName + " " + _cus.LastName, _cus.Matter_ID, txt_Payment.Text.Trim(), txt_GST.Text.Trim(), txt_Amount.Text.Trim(), txt_ReceiptNo.Text.Trim(), txt_Description.Text.Trim(), _cus.Salutation, _cus.LastName, _cus.Email, txt_Balance.Text.Trim(), GlobalVariable.LocationForPayment);
        }

        private void txt_Amount_TextChanged(object sender, EventArgs e)
        {
            if (txt_Amount.Text != "")
            {
                decimal cost = Convert.ToDecimal(txt_Amount.Text);
                decimal gst = (cost * 10) / 100;
                txt_GST.Text = gst.ToString();
            }
        }

        private void txt_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_Payment_TextChanged(object sender, EventArgs e)
        {
            if (txt_Payment.Text != ""&& txt_Amount.Text!="")
            {
                decimal cost = Convert.ToDecimal(txt_Amount.Text);
                decimal balance = cost - Convert.ToDecimal(txt_Payment.Text.Trim()+ Convert.ToDecimal(txt_GST.Text.Trim()));
                txt_Balance.Text = balance.ToString();
            }
        }

        
    }
}
