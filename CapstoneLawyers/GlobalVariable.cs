using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneLawyers
{
    public class GlobalVariable
    {
        
        public static string Path = "";
        
        public static string documentName = "";
        public static string pathword = "";

        ///////////////////////////////////
        public static List<string> configration = new List<string>();
        public static List<string> Location = new List<string>();

        public static string file_loaction = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));

        public static DTO.DTO_Customer Global_Customer = new DTO.DTO_Customer();
        public static string LocationForPayment = "";

        public static Boolean CheckFixPrice = true;
        

    }
}
