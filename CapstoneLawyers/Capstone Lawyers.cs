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
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace CapstoneLawyers
{
    public partial class Capstone_Lawyers : Form
    {
        BUS_PostCode BUS_PostCode = new BUS_PostCode();
        BUS_Customers Bus_Cus = new BUS_Customers();

        DTO_Customer cus = new DTO_Customer();
        DTO_PostCode DTO_PostCode = new DTO_PostCode();
        List<DTO_PostCode> ListPostCode = new List<DTO_PostCode>();
        string code = DateTime.Today.Year.ToString();
        Boolean flag = true;
        public Capstone_Lawyers()
        {
            InitializeComponent();
            BUS_PostCode.ReadLocation(ListPostCode);
            cbx_suburb.DataSource = ListPostCode;
            cbx_suburb.DisplayMember = "Suburb_state";
            code = code.Substring(2, 2);
        }

        private void cbx_suburb_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_suburb.Text = ListPostCode[cbx_suburb.SelectedIndex].Suburb;
            txt_Post_Code.Text = ListPostCode[cbx_suburb.SelectedIndex].Code;
            txt_State.Text = ListPostCode[cbx_suburb.SelectedIndex].state;
        }

        private void txt_Fees_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Fees_TextChanged(object sender, EventArgs e)
        {
            if (txt_Fees.Text != "")
            {
                decimal cost = Convert.ToDecimal(txt_Fees.Text);
                decimal gst = (cost * 10) / 100;
                txt_GST.Text = gst.ToString();
            }

        }

        private void cmd_create_Click(object sender, EventArgs e)
        {
            flag = true;
            cbx_MatterType.Enabled = true;
            cbx_Salutation.Enabled = true;
            cbx_suburb.Enabled = true;
            cbx_Status.Enabled = true;
            txt_address1.ReadOnly = false;
            txt_address2.ReadOnly = false;
            txt_comments.ReadOnly = false;
            txt_Disbursements.ReadOnly = false;
            Txt_Email.ReadOnly = false;
            txt_Fees.ReadOnly = false;
            txt_FName.ReadOnly = false;
            txt_GST.ReadOnly = false;
            Txt_LName.ReadOnly = false;
            txt_Matter_Des.ReadOnly = false;
            Txt_Phone.ReadOnly = false;
            txt_Post_Code.ReadOnly = false;
            txt_State.ReadOnly = false;
            cbx_MatterType.SelectedIndex = 0;
            cbx_Salutation.SelectedIndex = 0;
            cbx_suburb.Text = "";
            cbx_Status.SelectedIndex = 0;
            txt_address1.Text = "";
            txt_address2.Text = "";
            txt_comments.Text = "";
            txt_Disbursements.Text = "";
            Txt_Email.Text = "";
            txt_Fees.Text = "";
            txt_FName.Text = "";
            txt_GST.Text = "";
            Txt_LName.Text = "";
            txt_Matter_Des.Text = "";
            Txt_Phone.Text = "";
            txt_Post_Code.Text = "";
            txt_State.Text = "";
            cmd_Cost_Agreement.Enabled = false;
            cmd_create.Enabled = true;
            cmd_Disclosure.Enabled = false;
            cmd_edit.Enabled = false;
            cmd_Engagement.Enabled = false;
            Cmd_OfficeAccountting.Enabled = false;
            cmd_OpenFloder.Enabled = false;
            cmd_Payment.Enabled = false;
            cmd_save.Enabled = true;
            cmd_Time.Enabled = false;
            cmd_tax.Enabled = false;
            cmd_delete.Enabled = false;
        }

        private void cmd_save_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                getData();

                if (flag == false)
                {
                    cus.Matter_ID = dgv_Data.Rows[index].Cells[0].Value.ToString().Trim();
                    Bus_Cus.Update(cus);
                    Ts_progess.Text = "Customer : " + cus.FirstName + " has been Updated successfully";

                }
                else if (Bus_Cus.Insert(cus))
                {
                    Error_Provider.Clear();
                    Bus_Cus.CreateFolder(cus.Matter_ID);
                    cmd_Cost_Agreement.Enabled = true;
                    cmd_create.Enabled = true;
                    cmd_Disclosure.Enabled = true;
                    cmd_edit.Enabled = true;
                    cmd_Engagement.Enabled = true;
                    Cmd_OfficeAccountting.Enabled = true;
                    cmd_OpenFloder.Enabled = true;
                    cmd_Payment.Enabled = true;
                    cmd_save.Enabled = true;
                    cmd_Time.Enabled = true;
                    cmd_tax.Enabled = true;
                    cmd_delete.Enabled = true;
                    Ts_progess.Text = "Customer : " + cus.FirstName + " has been created successfully";
                }
                else
                {
                    Ts_progess.Text = "Internet Error!";
                }
                dgv_Data.DataSource = Bus_Cus.Load();

            }
            else
            {
                Ts_progess.Text = "Customer : " + cus.FirstName + " can be created unsuccessfully ";

            }


        }



        private void GetAllTextBoxes(Control.ControlCollection controls)
        {
            foreach (Control ctl in controls)
            {
                GetAllTextBoxes(ctl.Controls);
                if (ctl.GetType() == typeof(TextBox))
                {
                    allTextBoxControls.Add(ctl as TextBox);
                }
            }
        }
        List<TextBox> allTextBoxControls = new List<TextBox>(); //This List contains all TextBoxes
        private bool ValidateInput()
        {
            GetAllTextBoxes(Controls);

            foreach (TextBox box in allTextBoxControls)
            {
                if (box.Name != "txt_address1" && box.Name != "txt_address2" && box.Name != "txt_Search")
                {
                    if (string.IsNullOrWhiteSpace(box.Text))
                    {
                        Error_Provider.SetError(box, "Please fill all Detail");
                        return false;
                    }
                }
                if (!EmailIsValid(Txt_Email.Text.Trim()))
                {
                    Error_Provider.SetError(Txt_Email, "Please fill all Detail");
                    return false;
                }

            }
            return true;

        }

        private void cmd_edit_Click(object sender, EventArgs e)
        {
            flag = false;
            cbx_MatterType.Enabled = true;
            cbx_Salutation.Enabled = true;
            cbx_suburb.Enabled = true;
            cbx_Status.Enabled = true;
            txt_address1.ReadOnly = false;
            txt_address2.ReadOnly = false;
            txt_comments.ReadOnly = false;
            txt_Disbursements.ReadOnly = false;
            Txt_Email.ReadOnly = false;
            txt_Fees.ReadOnly = false;
            txt_FName.ReadOnly = false;
            txt_GST.ReadOnly = false;
            Txt_LName.ReadOnly = false;
            txt_Matter_Des.ReadOnly = false;
            Txt_Phone.ReadOnly = false;
            txt_Post_Code.ReadOnly = false;
            txt_State.ReadOnly = false;

            cmd_delete.Enabled = false;
            cmd_Cost_Agreement.Enabled = false;
            cmd_create.Enabled = true;
            cmd_Disclosure.Enabled = false;
            cmd_edit.Enabled = false;
            cmd_Engagement.Enabled = false;
            Cmd_OfficeAccountting.Enabled = false;
            cmd_OpenFloder.Enabled = false;
            cmd_Payment.Enabled = false;
            cmd_save.Enabled = true;
            cmd_Time.Enabled = false;
            cmd_tax.Enabled = false;
        }

        private void txt_Matter_Des_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Disbursements_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_FName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_LName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Capstone_Lawyers_Load(object sender, EventArgs e)
        {

            dgv_Data.DataSource = Bus_Cus.Load();
            HideColumn();
            cmd_Cost_Agreement.Enabled = true;
            cmd_create.Enabled = true;
            cmd_Disclosure.Enabled = true;
            cmd_edit.Enabled = true;
            cmd_Engagement.Enabled = true;
            Cmd_OfficeAccountting.Enabled = true;
            cmd_OpenFloder.Enabled = true;
            cmd_Payment.Enabled = true;
            cmd_save.Enabled = false;
            cmd_Time.Enabled = true;
            cmd_tax.Enabled = true;
            cbx_MatterType.Enabled = false;
            cbx_Salutation.Enabled = false;
            cbx_suburb.Enabled = false;
            cbx_Status.Enabled = false;
            txt_address1.ReadOnly = true;
            txt_address2.ReadOnly = true;
            txt_comments.ReadOnly = true;
            txt_Disbursements.ReadOnly = true;
            Txt_Email.ReadOnly = true;
            txt_Fees.ReadOnly = true;
            txt_FName.ReadOnly = true;
            txt_GST.ReadOnly = true;
            Txt_LName.ReadOnly = true;
            txt_Matter_Des.ReadOnly = true;
            Txt_Phone.ReadOnly = true;
            txt_Post_Code.ReadOnly = true;
            txt_State.ReadOnly = true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgv_Data.DataSource;

            bs.Filter = string.Format("CONVERT(" + dgv_Data.Columns[1].DataPropertyName + ", System.String) like '%" + txt_Search.Text.Replace("'", "''") + "%' OR CONVERT(" + dgv_Data.Columns[5].DataPropertyName + ", System.String) like '%" + txt_Search.Text.Replace("'", "''") + "%'  OR CONVERT(" + dgv_Data.Columns[6].DataPropertyName + ", System.String) like '%" + txt_Search.Text.Replace("'", "''") + "%' OR CONVERT(" + dgv_Data.Columns[8].DataPropertyName + ", System.String) like '%" + txt_Search.Text.Replace("'", "''") + "%' ");
            dgv_Data.DataSource = bs;
        }

        private void getData()
        {
            string s = cbx_MatterType.Text;

            //
            //Property
            //
            //
            if (s == "Family")
            {
                cus.Matter_ID = Bus_Cus.CreateID("FM" + code);

            }
            else if (s == "Immigration")
            {
                cus.Matter_ID = Bus_Cus.CreateID("IM" + code);
            }
            else if (s == "Conveyance")
            {
                cus.Matter_ID = Bus_Cus.CreateID("CO" + code);
            }
            else if (s == "Commercial")
            {
                cus.Matter_ID = Bus_Cus.CreateID("CM" + code);
            }
            else if (s == "Other")
            {
                cus.Matter_ID = Bus_Cus.CreateID("OT" + code);
            }
            cus.Address1 = txt_address1.Text.Trim();
            cus.Address2 = txt_address2.Text.Trim();
            cus.Address3 = ListPostCode[cbx_suburb.SelectedIndex].Suburb;
            cus.Comments = txt_comments.Text.Trim();
            cus.Disbursements = txt_Disbursements.Text.Trim();
            cus.Email = Txt_Email.Text.Trim();
            cus.Fees = txt_Fees.Text.Trim();
            cus.FirstName = txt_FName.Text.Trim();
            cus.LastName = Txt_LName.Text.Trim();
            cus.Matter_Des = txt_Matter_Des.Text.Trim();
            cus.Phone = Txt_Phone.Text.Trim();
            cus.PostCode = txt_Post_Code.Text.Trim();
            cus.Salutation = cbx_Salutation.Text;
            cus.State = txt_State.Text.Trim();
            cus.Status = cbx_Status.Text.Trim();
            cus.Active = "1";
            if(ckb_Hours.Checked)
            {
                cus.Check = 1;
            }
            else
            {
                cus.Check = 0;
            }
        }


        int index;
        string fileLocation="";
        private void dgv_Data_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                index = dgv_Data.CurrentRow.Index;
                if (index >= 0 && index < dgv_Data.RowCount - 1)
                {
                    //Family
                    //Property
                    //Immigration
                    //conveyance 
                    string s = dgv_Data.Rows[index].Cells[0].Value.ToString().Trim();
                    s = s.Substring(0, 2);
                    if (s == "IM")
                    {
                        cbx_MatterType.SelectedIndex = 2;
                    }
                    if (s == "CM")
                    {
                        cbx_MatterType.SelectedIndex = 3;
                    }
                    if (s == "FM")
                    {
                        cbx_MatterType.SelectedIndex = 0;
                    }
                    if (s == "CO")
                    {
                        cbx_MatterType.SelectedIndex = 1;
                    }
                    if (s == "OT")
                    {
                        cbx_MatterType.SelectedIndex = 4;
                    }


                    //`Matter_ID`, `Matter_Des`, `Fees`, `Disbursements`, `Salutation`, `FirstName`, `LastName`, `Email`, `Phone`, `Address1`, `Address2`, `Address3`, `PostCode`, `State`, `Comments`, `Status`
                    txt_Matter_Des.Text = dgv_Data.Rows[index].Cells[1].Value.ToString().Trim();
                    txt_Fees.Text = dgv_Data.Rows[index].Cells[2].Value.ToString().Trim();
                    txt_Disbursements.Text = dgv_Data.Rows[index].Cells[3].Value.ToString().Trim();
                    cbx_Salutation.Text = dgv_Data.Rows[index].Cells[4].Value.ToString().Trim();
                    txt_FName.Text = dgv_Data.Rows[index].Cells[5].Value.ToString().Trim();
                    Txt_LName.Text = dgv_Data.Rows[index].Cells[6].Value.ToString().Trim();
                    Txt_Email.Text = dgv_Data.Rows[index].Cells[7].Value.ToString().Trim();
                    Txt_Phone.Text = dgv_Data.Rows[index].Cells[8].Value.ToString().Trim();
                    txt_address1.Text = dgv_Data.Rows[index].Cells[9].Value.ToString().Trim();
                    txt_address2.Text = dgv_Data.Rows[index].Cells[10].Value.ToString().Trim();
                    cbx_suburb.Text = dgv_Data.Rows[index].Cells[11].Value.ToString().Trim();
                    txt_Post_Code.Text = dgv_Data.Rows[index].Cells[12].Value.ToString().Trim();
                    txt_State.Text = dgv_Data.Rows[index].Cells[13].Value.ToString().Trim();
                    txt_comments.Text = dgv_Data.Rows[index].Cells[14].Value.ToString().Trim();
                    cbx_Status.Text = dgv_Data.Rows[index].Cells[15].Value.ToString().Trim();
                    gb_ClientDetail.Text = dgv_Data.Rows[index].Cells[0].Value.ToString().Trim();
                    string d = dgv_Data.Rows[index].Cells[17].Value.ToString().Trim();
                    if (d=="True")
                    {
                        ckb_Hours.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        ckb_Hours.CheckState = CheckState.Unchecked;
                    }

                    fileLocation = GlobalVariable.file_loaction + "\\CapstoneLawyersData\\" + dgv_Data.Rows[index].Cells[0].Value.ToString().Trim();
                    GlobalVariable.LocationForPayment = fileLocation;
                    cmd_Cost_Agreement.Enabled = true;
                    cmd_create.Enabled = true;
                    cmd_Disclosure.Enabled = true;
                    cmd_edit.Enabled = true;
                    cmd_Engagement.Enabled = true;
                    Cmd_OfficeAccountting.Enabled = true;
                    cmd_OpenFloder.Enabled = true;
                    cmd_Payment.Enabled = true;
                    cmd_save.Enabled = false;
                    cmd_Time.Enabled = true;
                    cmd_tax.Enabled = true;
                    cbx_MatterType.Enabled = false;
                    cbx_Salutation.Enabled = false;
                    cbx_suburb.Enabled = false;
                    cbx_Status.Enabled = false;
                    txt_address1.ReadOnly = true;
                    txt_address2.ReadOnly = true;
                    txt_comments.ReadOnly = true;
                    txt_Disbursements.ReadOnly = true;
                    Txt_Email.ReadOnly = true;
                    txt_Fees.ReadOnly = true;
                    txt_FName.ReadOnly = true;
                    txt_GST.ReadOnly = true;
                    Txt_LName.ReadOnly = true;
                    txt_Matter_Des.ReadOnly = true;
                    Txt_Phone.ReadOnly = true;
                    txt_Post_Code.ReadOnly = true;
                    txt_State.ReadOnly = true;

                }
            }
            catch
            {

            }
        }

        private void Txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool EmailIsValid(string email)
        {
            return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        private void cmd_OpenFloder_Click(object sender, EventArgs e)
        {
            if(Location!=null)
            {
                System.Diagnostics.Process.Start("explorer", fileLocation);
            }
          
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            getData();
            DialogResult result = MessageBox.Show("Do you want to Hide this client in this list ?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                cus.Matter_ID = dgv_Data.Rows[index].Cells[0].Value.ToString().Trim();
                cus.Active = "0";
                if(Bus_Cus.Delete(cus))
                {
                    dgv_Data.DataSource = Bus_Cus.Load();
                    
                    Ts_progess.Text = "Your customer Name : " + cus.FirstName + " " + cus.LastName + " Have been Remove.";
                }
                else
                {
                    Ts_progess.Text = "Check internet Connection.";
                }

               

            }
           
        }

        private void HideColumn()
        {
            dgv_Data.Columns[2].Visible = false;
            dgv_Data.Columns[3].Visible = false;
            dgv_Data.Columns[4].Visible = false;
            dgv_Data.Columns[7].Visible = false;
            dgv_Data.Columns[9].Visible = false;
            dgv_Data.Columns[10].Visible = false;
            dgv_Data.Columns[11].Visible = false;
            dgv_Data.Columns[12].Visible = false;
            dgv_Data.Columns[13].Visible = false;
            dgv_Data.Columns[14].Visible = false;
            dgv_Data.Columns[16].Visible = false;
        }


        BUS_Letter Bus_Letter = new BUS_Letter();
        private void cmd_Cost_Agreement_Click(object sender, EventArgs e)
        {
            Bus_Cus.CreateFolder(dgv_Data.Rows[index].Cells[0].Value.ToString().Trim());
            Bus_Letter.Kill_process();

            Bus_Letter.FillCostAgreement("" + dgv_Data.Rows[index].Cells[5].Value.ToString().Trim() + " " + dgv_Data.Rows[index].Cells[6].Value.ToString().Trim(), dgv_Data.Rows[index].Cells[0].Value.ToString().Trim(), "Uyen Tu", fileLocation);

        }

        private void cmd_Engagement_Click(object sender, EventArgs e)
        {
            Bus_Cus.CreateFolder(dgv_Data.Rows[index].Cells[0].Value.ToString().Trim());
            Bus_Letter.Kill_process();
            Bus_Letter.FillEngagementLetter("" + dgv_Data.Rows[index].Cells[5].Value.ToString().Trim() + " " + dgv_Data.Rows[index].Cells[6].Value.ToString().Trim(), dgv_Data.Rows[index].Cells[0].Value.ToString().Trim(), Txt_Email.Text.Trim(), txt_address1.Text.Trim() + " " + txt_address2.Text.Trim(), cbx_suburb.Text.Trim() + " " + txt_State.Text.Trim() + " " + txt_Post_Code.Text.Trim(), cbx_Salutation.Text,txt_Fees.Text.Trim(),txt_Disbursements.Text.Trim(), txt_Matter_Des.Text.Trim(), Txt_LName.Text.Trim(), fileLocation);
        }

        private void cmd_Disclosure_Click(object sender, EventArgs e)
        {
            Bus_Cus.CreateFolder(dgv_Data.Rows[index].Cells[0].Value.ToString().Trim());
            Bus_Letter.Kill_process();

            Bus_Letter.FillDisclosure("" + dgv_Data.Rows[index].Cells[5].Value.ToString().Trim() + " " + dgv_Data.Rows[index].Cells[6].Value.ToString().Trim(), dgv_Data.Rows[index].Cells[0].Value.ToString().Trim(), "Uyen Tu", txt_Fees.Text.Trim(), txt_Disbursements.Text.Trim(),fileLocation);

        }

        private void cmd_Payment_Click(object sender, EventArgs e)
        {
            Bus_Cus.CreateFolder(dgv_Data.Rows[index].Cells[0].Value.ToString().Trim());
            getData();
            cus.Matter_ID = dgv_Data.Rows[index].Cells[0].Value.ToString().Trim();
            GlobalVariable.Global_Customer = cus;
            Payment frm_payment = new Payment();
            
            frm_payment.WindowState = FormWindowState.Normal;
            frm_payment.StartPosition = FormStartPosition.CenterScreen;
            frm_payment.Show();

        }

        private void cmd_Time_Click(object sender, EventArgs e)
        {

            getData();
            cus.Matter_ID = dgv_Data.Rows[index].Cells[0].Value.ToString().Trim();
            GlobalVariable.Global_Customer = cus;
            Time_And_Fees frm_time = new Time_And_Fees();

            frm_time.WindowState = FormWindowState.Normal;
            frm_time.StartPosition = FormStartPosition.CenterScreen;
            frm_time.Show();
        }

        private void ckb_Hours_CheckedChanged(object sender, EventArgs e)
        {
            if(ckb_Hours.Checked)
            {
                GlobalVariable.CheckFixPrice = false;
            }
        }

        private void cmd_tax_Click(object sender, EventArgs e)
        {
            Bus_Cus.CreateFolder(dgv_Data.Rows[index].Cells[0].Value.ToString().Trim());
            Bus_Letter.Kill_process();

            DTO_TaxInvoice _tax = new DTO_TaxInvoice();
            BUS_TaxInvoce _bus_tax = new BUS_TaxInvoce();
            BUS_Payment _bus_pay = new BUS_Payment();
            DataTable tb_payment = new DataTable();
            _tax.Matter_ID = dgv_Data.Rows[index].Cells[0].Value.ToString().Trim();

            DataTable tb_tax = new DataTable();
            tb_tax = _bus_tax.Load(_tax.Matter_ID);
            if(tb_tax.Rows.Count>0)
            {
                _tax.Tax_No = tb_tax.Rows[0][0].ToString().Trim();
            }
            else
            {
                _tax.Tax_No = _bus_tax.CreateID();
            }
           

            _bus_tax.Insert(_tax);

            BUS_TimeAndFees _bus_time = new BUS_TimeAndFees();
            DataTable tb_Sum;
            tb_payment = _bus_pay.Load(_tax.Matter_ID);

            string d = dgv_Data.Rows[index].Cells[17].Value.ToString().Trim();
            if (d == "True")
            {
                tb_Sum = _bus_time.LoadFixedPrice(_tax.Matter_ID);
            }
            else
            {
                tb_Sum = _bus_time.LoadHoursPrice(_tax.Matter_ID);
            }
            string Des = "";
            for(int i=0;i<tb_Sum.Rows.Count;i++)
            {
                Des += tb_Sum.Rows[i][2].ToString().Trim() + "\t" + tb_Sum.Rows[i][3].ToString().Trim()+"\n";
            }
            

            Bus_Letter.Fill_TaxInvoice("" + dgv_Data.Rows[index].Cells[5].Value.ToString().Trim() + " " + dgv_Data.Rows[index].Cells[6].Value.ToString().Trim(), dgv_Data.Rows[index].Cells[0].Value.ToString().Trim(),_tax.Tax_No, txt_address1.Text.Trim() + " " + txt_address2.Text.Trim(), cbx_suburb.Text.Trim() + " " + txt_State.Text.Trim() + " " + txt_Post_Code.Text.Trim(),cbx_Salutation.Text.Trim(),Des,tb_payment.Rows[0][2].ToString().Trim(),tb_payment.Rows[0][3].ToString().Trim(),tb_payment.Rows[0][4].ToString().Trim(),tb_payment.Rows[0][5].ToString().Trim(),dgv_Data.Rows[index].Cells[6].Value.ToString().Trim(), fileLocation);

        }

        private void cmd_open_Click(object sender, EventArgs e)
        {
            getData();
            cus.Matter_ID = dgv_Data.Rows[index].Cells[0].Value.ToString().Trim();
            GlobalVariable.Global_Customer = cus;
            Send_Email frm_payment = new Send_Email();

            frm_payment.WindowState = FormWindowState.Normal;
            frm_payment.StartPosition = FormStartPosition.CenterScreen;
            frm_payment.Show();

        }
    }
       
}
