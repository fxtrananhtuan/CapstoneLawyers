using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoursPrice
    {
        string _Matter_ID, _Date, _Description;
        string _No;
        decimal _Hours;

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

        public decimal Hours
        {
            get
            {
                return _Hours;
            }

            set
            {
                _Hours = value;
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
