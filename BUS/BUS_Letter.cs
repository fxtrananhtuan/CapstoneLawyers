using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Diagnostics;

namespace BUS
{
    public class BUS_Letter
    {
        DAO_COst_Agreement DAO_Cost = new DAO_COst_Agreement();
        DAO_Engagement DAO_Engagement = new DAO_Engagement();
        DAO_Disclosure DAO_Dis = new DAO_Disclosure();
        DAO_PaymentReceipt DAO_PR = new DAO_PaymentReceipt();
        DAO_TaxInvoice _DAO_TAX = new DAO_TaxInvoice();

        public void FillCostAgreement (string client, string matter, string contact, string Matter_location)
        {
            
            string templatelocation = DAO_Cost.ReadTXT();
            DAO_Cost.Fill_On_Word(client, matter, contact, Matter_location, templatelocation);
 
        }
        public void FillEngagementLetter(string client, string matter, string email, string address1, string address2, string salutation,string fees,string disb, string MatterDes, string lastname, string Matter_location)
        {
            string templatelocation = DAO_Cost.ReadTXT();
            
            DAO_Engagement.Fill_On_Word(client, matter, email, address1, address2, salutation,covertmoney(fees), covertmoney(disb), MatterDes, lastname, Matter_location, templatelocation);

        }
        public void FillDisclosure(string client, string matter, string contact, string fees, string disb, string Matter_location)
        {
            string templatelocation = DAO_Cost.ReadTXT();
            DAO_Dis.Fill_On_Word(client, matter, contact, covertmoney(fees), covertmoney(disb), Matter_location, templatelocation);
        }

        public void Fill_On_Word(string client, string matter, string Received, string GST, string Amount, string Receipt, string MatterDes, string mr, string lastname, string email, string Balance, string Matter_location)
        {
            string templatelocation = DAO_Cost.ReadTXT();
            DAO_PR.Fill_On_Word(client, matter, covertmoney(Received), covertmoney( GST), covertmoney(Amount), Receipt, MatterDes, mr, lastname, email, covertmoney(Balance), Matter_location, templatelocation);
        }

        public void Fill_TaxInvoice(string client, string matter, string TaxNo, string address1, string address2, string salutation, string Des, string Amount, string GST, string Received, string Balance, string lastname, string Matter_location)
        {
            string templatelocation = DAO_Cost.ReadTXT();
            _DAO_TAX.Fill_TaxInvoice(client, matter, TaxNo, address1, address2, salutation, Des, covertmoney(Amount), covertmoney(GST), covertmoney(Received), covertmoney(Balance), lastname, Matter_location, templatelocation);
        }

        private string covertmoney (string s)
        {
            decimal moneyvalue = Convert.ToDecimal(s);
            string money = String.Format("{0:C}", moneyvalue);
            return money;
        }

        public string Create_folder(string MatterID)
        {
            return _DAO_TAX.Create_folder(MatterID);
        }

        public void Kill_process ()
        {
            Process[] processes = Process.GetProcessesByName("WINWORD");

            foreach (Process process in processes)
            {
                TimeSpan runningTime = DateTime.Now - process.StartTime;
                if (runningTime.TotalMinutes > 2)
                    process.Kill();
            }
        }

    }
}
