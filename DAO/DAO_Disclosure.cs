﻿using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Disclosure
    {
        Object oMissing = System.Reflection.Missing.Value;





        public void Fill_On_Word(string client, string matter, string contact, string fees, string disb, string Matter_location, string template_location)
        {
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Document wordDoc = new Document();
            Object oTemplatePath = template_location + "DisclosureStatement.dotx";
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

                    String fieldName ="";

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

                    if (fieldName == "Fees")
                    {

                        myMergeField.Select();

                        wordApp.Selection.TypeText(fees);

                    }

                    if (fieldName == "Disb")
                    {

                        myMergeField.Select();

                        wordApp.Selection.TypeText(disb);

                    }
                    //«Contact»
                    if (fieldName == "Contact")
                    {

                        myMergeField.Select();

                        wordApp.Selection.TypeText(contact);

                    }
                    //«Date»
                    if (fieldName == "Date")
                    {

                        myMergeField.Select();

                        wordApp.Selection.TypeText(DateTime.Today.ToShortDateString());

                    }
                }
            }
            string name = matter + "-DisclosureStatement";
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
