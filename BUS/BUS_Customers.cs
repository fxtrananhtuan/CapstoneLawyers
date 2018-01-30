using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_Customers
    {
        DAO_Customer DAO_cus = new DAO_Customer();
        public DataTable Load()
        {
            return DAO_cus.Load();
        }

        public bool Insert(DTO_Customer Cus)
        {
            return DAO_cus.Insert(Cus);
        }
        public string CreateID (string Code)
        {
            return DAO_cus.CreateID(Code);
        }
        public bool Update (DTO_Customer cus)
        {
            return DAO_cus.Update(cus);
        }
        public bool Delete (DTO_Customer cus)
        {
            return DAO_cus.Delete(cus);
        }
        public string CreateFolder (string MatterID)
        {
            return DAO_cus.Create_folder(MatterID);
        }
    }
    
}
