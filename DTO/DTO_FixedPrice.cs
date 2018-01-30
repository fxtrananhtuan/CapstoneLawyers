using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_FixedPrice
    {
        string _Matter_ID, _Date, _Description, _No;
        decimal _Amount;

        public decimal Amount
        {
            get
            {
                return _Amount;
            }

            set
            {
                _Amount = value;
            }
        }

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

        public string Date
        {
            get
            {
                return _Date;
            }

            set
            {
                _Date = value;
            }
        }

        public string Description
        {
            get
            {
                return _Description;
            }

            set
            {
                _Description = value;
            }
        }

        public string No
        {
            get
            {
                return _No;
            }

            set
            {
                _No = value;
            }
        }
    }
}
