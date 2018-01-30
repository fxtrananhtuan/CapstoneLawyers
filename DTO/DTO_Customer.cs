using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Customer
    {
        string _Matter_ID, _Matter_Des, _Fees, _Disbursements, _Salutation, _FirstName, _LastName, _Email, _Phone, _Address1, _Address2, _Address3, _PostCode, _State, _Comments, _Status;
        string _Active;
        int _check;
        public string Address1
        {
            get
            {
                return _Address1;
            }

            set
            {
                _Address1 = value;
            }
        }

        public string Address2
        {
            get
            {
                return _Address2;
            }

            set
            {
                _Address2 = value;
            }
        }

        public string Address3
        {
            get
            {
                return _Address3;
            }

            set
            {
                _Address3 = value;
            }
        }

        public string Comments
        {
            get
            {
                return _Comments;
            }

            set
            {
                _Comments = value;
            }
        }

        public string Disbursements
        {
            get
            {
                return _Disbursements;
            }

            set
            {
                _Disbursements = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        public string Fees
        {
            get
            {
                return _Fees;
            }

            set
            {
                _Fees = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _FirstName;
            }

            set
            {
                _FirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _LastName;
            }

            set
            {
                _LastName = value;
            }
        }

        public string Matter_Des
        {
            get
            {
                return _Matter_Des;
            }

            set
            {
                _Matter_Des = value;
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

        public string Phone
        {
            get
            {
                return _Phone;
            }

            set
            {
                _Phone = value;
            }
        }

        public string PostCode
        {
            get
            {
                return _PostCode;
            }

            set
            {
                _PostCode = value;
            }
        }

        public string Salutation
        {
            get
            {
                return _Salutation;
            }

            set
            {
                _Salutation = value;
            }
        }

        public string State
        {
            get
            {
                return _State;
            }

            set
            {
                _State = value;
            }
        }

        public string Status
        {
            get
            {
                return _Status;
            }

            set
            {
                _Status = value;
            }
        }

        public string Active
        {
            get
            {
                return _Active;
            }

            set
            {
                _Active = value;
            }
        }

        public int Check
        {
            get
            {
                return _check;
            }

            set
            {
                _check = value;
            }
        }
    }
}
