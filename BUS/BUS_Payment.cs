using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_Payment
    {
        DAO_Payment DAO_payment = new DAO_Payment();
        public DataTable Load(string s)
        {
            string sql = "SELECT * FROM Payment WHERE Matter_ID='"+s+"'";
            return DAO_payment.Load(sql);
        }
        public string CreateID()
        {
            string CODE = DateTime.Today.Year.ToString();
            CODE = CODE.Substring(2, 2);
            return DAO_payment.CreateID(CODE);
        }
        public bool Insert(DTO_Payment payment)
        {
            return DAO_payment.Insert(payment);
        }
        public bool Update(DTO_Payment payment)
        {
            return DAO_payment.Update(payment);
        }
    }
}
