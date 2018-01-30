using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Payment
    {
        string _Matter_ID, _Receipt_No, _Description;
        decimal _Amount, _GST, _Received, _Balance;

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

        public decimal GST
        {
            get
            {
                return _GST;
            }

            set
            {
                _GST = value;
            }
        }

        public decimal Received
        {
            get
            {
                return _Received;
            }

            set
            {
                _Received = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return _Balance;
            }

            set
            {
                _Balance = value;
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

        public string Receipt_No
        {
            get
            {
                return _Receipt_No;
            }

            set
            {
                _Receipt_No = value;
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
    }
}
