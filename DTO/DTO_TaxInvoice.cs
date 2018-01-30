using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TaxInvoice 
    {
        string _Matter_ID, _Tax_No;

        public string Matter_ID
        {
            get
            {
                return _Matter_ID;
            }

            set
            {
                _Matter_ID = value;
            }
        }

        public string Tax_No
        {
            get
            {
                return _Tax_No;
            }

            set
            {
                _Tax_No = value;
            }
        }
    }
}
