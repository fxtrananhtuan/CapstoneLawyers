using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_OpenOutLook
    {

        public static Boolean CostAgreement = false;
        public static Boolean EngagementLetter = false;
        public static Boolean TaxInvoice = false;
        public static Boolean DisclosureStatement = false;
        public static Boolean PaymentReceipt = false;

        Microsoft.Office.Interop.Outlook.Application objApp = new Microsoft.Office.Interop.Outlook.Application();
        public void OpenOutLook (string Body, string Subject, string client,string location,string matterID)
        {
            Kill_process();
            Microsoft.Office.Interop.Outlook.Application objApp = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.MailItem mail = null;
            mail = (Microsoft.Office.Interop.Outlook.MailItem)objApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
            mail.Body = Body;
            mail.Subject = Subject;
            mail.To = client;
            if(CostAgreement)
            {
                mail.Attachments.Add((object)@""+location+"\\"+matterID+ "-CostsAgreement.pdf",
     Microsoft.Office.Interop.Outlook.OlAttachmentType.olEmbeddeditem, 1, (object)"Costs Agreement");
            }
            if(EngagementLetter)
            {
                mail.Attachments.Add((object)@"" + location + "\\" + matterID + "-EngagementLetter.pdf",
    Microsoft.Office.Interop.Outlook.OlAttachmentType.olEmbeddeditem, 1, (object)"Engagement Letter");
            }

            if (TaxInvoice)
            {
                mail.Attachments.Add((object)@"" + location + "\\" + matterID + "-TaxInvoice.pdf",
    Microsoft.Office.Interop.Outlook.OlAttachmentType.olEmbeddeditem, 1, (object)"Tax Invoice");
            }
            if (DisclosureStatement)
            {
                mail.Attachments.Add((object)@"" + location + "\\" + matterID + "-DisclosureStatement.pdf",
    Microsoft.Office.Interop.Outlook.OlAttachmentType.olEmbeddeditem, 1, (object)"Disclosure Statement");
            }
            if (PaymentReceipt)
            {
                mail.Attachments.Add((object)@"" + location + "\\" + matterID + "-PaymentReceipt.pdf",
    Microsoft.Office.Interop.Outlook.OlAttachmentType.olEmbeddeditem, 1, (object)"Payment Receipt");
            }
            //To show email window
            mail.Display();
        }

        public void Kill_process()
        {
            Process[] processes = Process.GetProcessesByName("OUTLOOK");

            foreach (Process process in processes)
            {
                TimeSpan runningTime = DateTime.Now - process.StartTime;
                if (runningTime.TotalMinutes > 2)
                    process.Kill();
            }
        }
    }
}
