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
using System.Globalization;

namespace CapstoneLawyers
{
    public partial class Time_And_Fees : Form
    {
        public Time_And_Fees()
        {
            InitializeComponent();
        }

        BUS_TimeAndFees _Bus_Time = new BUS_TimeAndFees();
        DTO_Customer _cus = new DTO_Customer();
        DTO_FixedPrice _Fix = new DTO_FixedPrice();
        DTO_HoursPrice _Hr = new DTO_HoursPrice();
        private void Time_And_Fees_Load(object sender, EventArgs e)
        {
            if(GlobalVariable.CheckFixPrice)
            {
                tab_Hours.TabPages.Remove(tab_Fixedprice);
            }
            else
            {
                tab_Hours.TabPages.Remove(tab_ByHours);
            }
            _cus = GlobalVariable.Global_Customer;
            dgv_Fixed.DataSource = _Bus_Time.LoadFixedPrice(_cus.Matter_ID.Trim());
            dgv_hours.DataSource = _Bus_Time.LoadHoursPrice(_cus.Matter_ID.Trim());

          

          


            txt_Amount.ReadOnly = true;
            txt_desF.ReadOnly = true;
            dtp_F.Enabled = false;
            txt_Hours.ReadOnly = true;
            txt_desH.ReadOnly = true;
            dtp_H.Enabled = false;
        }
        Boolean flag = true;
        private void cmd_save_Click(object sender, EventArgs e)
        {
            string s = string.Format("{0:C}", Convert.ToDecimal(txt_Amount.Text.Trim()));
            _Fix.Amount =Convert.ToDecimal(s);
            _Fix.Date = dtp_F.Text.Trim();
            _Fix.Description = txt_desF.Text.Trim();
            _Fix.Matter_ID = _cus.Matter_ID;
           
            if(flag)
            {
                _Fix.No = _Bus_Time.CreateID_FixedPrice("F");
                _Bus_Time.Insert_FixedPrice(_Fix);
            }
            else
            {
                _Fix.No = dgv_Fixed.Rows[index].Cells[0].Value.ToString().Trim();
                _Bus_Time.Update_FixedPrice(_Fix);
            }
            dgv_Fixed.DataSource = _Bus_Time.LoadFixedPrice(_cus.Matter_ID);
            cmd_new.Enabled = true;
            cmd_save.Enabled = false;
            cmd_delete.Enabled = true;
            cmd_edit.Enabled = true;
        }

        private void cmd_edit_Click(object sender, EventArgs e)
        {
            txt_Amount.ReadOnly = false;
            txt_desF.ReadOnly = false;
            dtp_F.Enabled = true;
            flag = false;
            cmd_new.Enabled = true;
            cmd_save.Enabled = true;
            cmd_delete.Enabled = false;
            cmd_edit.Enabled = true;
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            _Fix.Amount = Convert.ToDecimal(txt_Amount.Text.Trim());
            _Fix.Date = dtp_F.Text.Trim();
            _Fix.Description = txt_desF.Text.Trim();
            _Fix.Matter_ID = _cus.Matter_ID;
            _Fix.No = dgv_Fixed.Rows[index].Cells[0].Value.ToString().Trim();

            DialogResult result = MessageBox.Show("Do you want to delete this row?", "Delete Row", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result==DialogResult.Yes)
            {
                _Bus_Time.Delete_FixedPrice(_Fix);
            }
            cmd_new.Enabled = true;
            cmd_save.Enabled = false;
            cmd_delete.Enabled = true;
            cmd_edit.Enabled = true;
        }

        private void cmd_new_Click(object sender, EventArgs e)
        {
            flag = true;
            txt_Amount.ReadOnly = false;
            txt_desF.ReadOnly = false;
            dtp_F.Enabled = true;
            cmd_new.Enabled = true;
            cmd_save.Enabled = true;
            cmd_delete.Enabled = false;
            cmd_edit.Enabled = false;
        }

        int index;
        private void dgv_Fixed_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                index = dgv_Fixed.CurrentRow.Index;
                if (index >= 0 && index < dgv_Fixed.RowCount - 1)
                {
                    DateTime dateVal = DateTime.ParseExact(dgv_Fixed.Rows[index].Cells[2].Value.ToString().Trim(), "d/MM/yyyy", CultureInfo.InvariantCulture);
                    dtp_F.Value = dateVal;
                    txt_Amount.Text= dgv_Fixed.Rows[index].Cells[4].Value.ToString().Trim();
                    txt_desF.Text= dgv_Fixed.Rows[index].Cells[3].Value.ToString().Trim();

                    decimal total = dgv_Fixed.Rows.Cast<DataGridViewRow>()
              .Sum(t => Convert.ToDecimal(t.Cells[4].Value));
                    lbl_total.Text = "Total Cost : " + total;

                    cmd_new.Enabled = true;
                    cmd_save.Enabled = false;
                    cmd_delete.Enabled = true;
                    cmd_edit.Enabled = true;
                    txt_Amount.ReadOnly = true;
                    txt_desF.ReadOnly = true;
                    dtp_F.Enabled = false;
                }
            }
            catch { }
        }
        Boolean flag2 = true;
        private void cmd_newH_Click(object sender, EventArgs e)
        {
            flag2 = true;
            txt_Hours.ReadOnly = false;
            txt_desH.ReadOnly = false;
            dtp_H.Enabled = true;
            cmd_newH.Enabled = true;
            cmd_saveH.Enabled = true;
            cmd_DeleteH.Enabled = false;
            cmd_EditH.Enabled = false;
        }

        private void cmd_saveH_Click(object sender, EventArgs e)
        {
            _Hr.Hours = Convert.ToDecimal(txt_Hours.Text.ToString().Trim());
            _Hr.Date = dtp_H.Text.Trim();
            _Hr.Description = txt_desH.Text.Trim();
            _Hr.Matter_ID = _cus.Matter_ID;
            
            if (flag2)
            {
                _Hr.No = _Bus_Time.CreateID_Hour("H");
                _Bus_Time.Insert_HoursPrice(_Hr);
            }
            else
            {
                _Hr.No = dgv_hours.Rows[index].Cells[0].Value.ToString().Trim();
                _Bus_Time.Update_HoursPrice(_Hr);
            }
            dgv_hours.DataSource = _Bus_Time.LoadHoursPrice(_cus.Matter_ID.Trim());
            cmd_newH.Enabled = true;
            cmd_saveH.Enabled = false;
            cmd_DeleteH.Enabled = true;
            cmd_EditH.Enabled = true;

        }

        private void cmd_EditH_Click(object sender, EventArgs e)
        {
            txt_Hours.ReadOnly = false;
            txt_desH.ReadOnly = false;
            dtp_H.Enabled = true;
            flag2 = false;
            cmd_newH.Enabled = true;
            cmd_saveH.Enabled = true;
            cmd_DeleteH.Enabled = false;
            cmd_EditH.Enabled = true;
        }

        private void cmd_DeleteH_Click(object sender, EventArgs e)
        {

            _Hr.Hours = Convert.ToDecimal(txt_Hours.Text.Trim());
            _Hr.Date = dtp_H.Text.Trim();
            _Hr.Description = txt_desH.Text.Trim();
            _Hr.Matter_ID = _cus.Matter_ID;
            _Hr.No = dgv_hours.Rows[index].Cells[0].Value.ToString().Trim();

            DialogResult result = MessageBox.Show("Do you want to delete this row?", "Delete Row", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _Bus_Time.Delete_HoursPrice(_Hr);
            }
            cmd_newH.Enabled = true;
            cmd_saveH.Enabled = false;
            cmd_DeleteH.Enabled = true;
            cmd_EditH.Enabled = true;

        }

        private void dgv_hours_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                index = dgv_hours.CurrentRow.Index;
                if (index >= 0 && index < dgv_hours.RowCount - 1)
                {
                    DateTime dateVal = DateTime.ParseExact(dgv_hours.Rows[index].Cells[2].Value.ToString().Trim(), "d/MM/yyyy", CultureInfo.InvariantCulture);
                    dtp_H.Value = dateVal;
                    txt_Hours.Text = dgv_hours.Rows[index].Cells[4].Value.ToString().Trim();
                    txt_desH.Text = dgv_hours.Rows[index].Cells[3].Value.ToString().Trim();
                    cmd_newH.Enabled = true;
                    cmd_saveH.Enabled = false;
                    cmd_DeleteH.Enabled = true;
                    cmd_EditH.Enabled = true;
                    txt_Hours.ReadOnly = true;
                    txt_desH.ReadOnly = true;
                    dtp_H.Enabled = false;
                    decimal totalH = dgv_hours.Rows.Cast<DataGridViewRow>()
             .Sum(t => Convert.ToDecimal(t.Cells[4].Value));
                    lbl_TotalH.Text = "Total Cost : " + totalH*300;
                }
            }
            catch { }
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
    }
}
