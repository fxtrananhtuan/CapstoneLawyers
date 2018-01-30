using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
     public class BUS_TaxInvoce
    {
        DAO_TaxInvoice Tax = new DAO_TaxInvoice();
        public string CreateID()
        {
            string CODE = DateTime.Today.Year.ToString();
            CODE = CODE.Substring(2, 2);
            return Tax.CreateID(CODE);
        }
        public bool Insert(DTO_TaxInvoice invoice)
        {
            return Tax.Insert(invoice);
        }
        public DataTable Load(string Matter)
        {
            return Tax.Load(Matter);
        }
    }
}
