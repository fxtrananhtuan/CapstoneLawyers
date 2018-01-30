using Microsoft.Office.Interop.Word;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class DAO_TaxInvoice:DAO_DataProvider
    {
        Object oMissing = System.Reflection.Missing.Value;

        

        public bool Insert(DTO_TaxInvoice Invoice)
        {
            connect();

            string sql = "INSERT INTO capston1_customers.TaxInvoice (Tax_No, Matter_ID) VALUES (@Tax_No, @Matter_ID)";

            try
            {
                _cmd = new MySqlCommand(sql, _cnn);
                _cmd.Parameters.Add("@Tax_No", MySqlDbType.VarChar, 30).Value = Invoice.Tax_No;
                _cmd.Parameters.Add("@Matter_ID", MySqlDbType.VarChar,30).Value = Invoice.Matter_ID;
                _cmd.ExecuteNonQuery();
                _cmd.Dispose();
                disconnect();
            }
            catch (Exception ex)
            {
                disconnect();
                return false;
                throw ex;
            }
            return true;
        }

        public System.Data.DataTable Load(string Matter)
        {
            DataSet _DS = new DataSet();
            System.Data.DataTable tb;
            connect();
            try
            {
                string sql = "select * from TaxInvoice where Matter_ID ='"+Matter+"'";
                _cmd = new MySqlCommand(sql, _cnn);
                _dt = new MySqlDataAdapter(_cmd);
                _dt.Fill(_DS);
                _cmd.Dispose();
                tb = _DS.Tables[0];
                disconnect();
            }
            catch (Exception ex)
            {
                disconnect();

                throw ex;
            }
            return tb;
        }



        public string CreateID(string CODE)
        {
            string ID = CreateIDCode(CODE, "Tax_No", "TaxInvoice", 5);
            return ID;
        }


        public void Fill_TaxInvoice(string client, string matter, string TaxNo, string address1, string address2, string salutation, string Des, string Amount, string GST,string Received,string Balance, string lastname, string Matter_location, string template_location)
        {
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Document wordDoc = new Document();

            Object oTemplatePath = template_location + "TaxInvoice.dotx";
            wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);
            foreach (Field myMergeField in wordDoc.Fields)
            {


                Range rngFieldCode = myMergeField.Code;

                String fieldText = rngFieldCode.Text;



                // ONLY GETTING THE MAILMERGE FIELDS

                if (fieldText.StartsWith(" MERGEFIELD"))
                {

                    // THE TEXT COMES IN THE FORMAT OF

                    // MERGEFIELD  MyFieldName  \\* MERGEFORMAT

                    // THIS HAS TO BE EDITED TO GET ONLY THE FIELDNAME "MyFieldName"

                    Int32 endMerge = fieldText.IndexOf("\\");

                    Int32 fieldNameLength = fieldText.Length - endMerge;

                    String fieldName;
                    if (endMerge > 1)
                    {
                        fieldName = fieldText.Substring(11, endMerge - 11);
                    }
                    else
                        fieldName = " ";


                    // GIVES THE FIELDNAMES AS THE USER HAD ENTERED IN .dot FILE

                    fieldName = fieldName.Trim();

                    // **** FIELD REPLACEMENT IMPLEMENTATION GOES HERE ****//

                    // THE PROGRAMMER CAN HAVE HIS OWN IMPLEMENTATIONS HERE

                    if (fieldName == "Client")
                    {

                        myMergeField.Select();

                        wordApp.Selection.TypeText(client);

                    }
                    //Matter
                    if (fieldName == "Matter")
                    {

                        myMergeField.Select();

                        wordApp.Selection.TypeText(matter);

                    }
                    //«address1»
                    if (fieldName == "Address1")
                    {

                        myMergeField.Select();

                        wordApp.Selection.TypeText(address1);

                    }
                    //«address2»
                    if (fieldName == "Address2")
                    {

                        myMergeField.Select();

                        wordApp.Selection.TypeText(address2);

                    }

                    
                    if (fieldName == "TaxNo")
                    {

                        myMergeField.Select();

                        wordApp.Selection.TypeText(TaxNo);

                    }
                    if (fieldName == "Des")
                    {

                        myMergeField.Select();

                        wordApp.Selection.TypeText(Des);

                    }
                    //LastName
                    if (fieldName == "LastName")
                    {

                        myMergeField.Select();

                        wordApp.Selection.TypeText(lastname);

                    }
                    if (fieldName == "Mr")
                    {

                        myMergeField.Select();

                        wordApp.Selection.TypeText(salutation);

                    }
                    if (fieldName == "Amount")
                    {

                        myMergeField.Select();

                        wordApp.Selection.TypeText(Amount);

                    }
                    if (fieldName == "GST")
                    {

                        myMergeField.Select();

                        wordApp.Selection.TypeText(GST);

                    }
                    if (fieldName == "Received")
                    {

                        myMergeField.Select();

                        wordApp.Selection.TypeText(Received);

                    }
                    if (fieldName == "Balance")
                    {

                        myMergeField.Select();

                        wordApp.Selection.TypeText(Balance);

                    }

                    //«Date»
                    if (fieldName == "Date")
                    {

                        myMergeField.Select();

                        wordApp.Selection.TypeText(DateTime.Today.ToShortDateString());

                    }
                }
            }
            string name = matter + "-TaxInvoice";
            string filename = Matter_location + "\\" + name + ".docx";

            try
            {
                wordDoc.SaveAs(filename);
                wordApp.Documents.Open(filename);
                wordDoc.SaveAs2(Matter_location + "\\" + name + ".pdf", WdSaveFormat.wdFormatPDF);
                wordDoc.Close();
                wordApp.Documents.Open(filename);
            }
            catch
            {

            }



        }
    }
}
