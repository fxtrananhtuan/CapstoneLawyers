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
    public class BUS_TimeAndFees
    {
        DAO_TimeAndFees _DAO_Time = new DAO_TimeAndFees();
        public DataTable LoadFixedPrice(string s)
        {
            return _DAO_Time.LoadFixedPrice( s);
        }
        public DataTable LoadHoursPrice(string s)
        {
            return _DAO_Time.LoadHoursPrice(s);
        }
        public string CreateID_Hour (string code)
        {
            return _DAO_Time.CreateID_Hour(code);
        }
        public string CreateID_FixedPrice(string CODE)
        {
            return _DAO_Time.CreateID_FixedPrice(CODE);
        }
        public bool Insert_FixedPrice(DTO_FixedPrice Fixed)
        {
            return _DAO_Time.Insert_FixedPrice(Fixed);
        }
        public bool Insert_HoursPrice(DTO_HoursPrice Fixed)
        {
            return _DAO_Time.Insert_HoursPrice(Fixed);
        }
        public bool Update_FixedPrice(DTO_FixedPrice Fixed)
        {
            return _DAO_Time.Update_FixedPrice(Fixed);
        }
        public bool Update_HoursPrice(DTO_HoursPrice Fixed)
        {
            return _DAO_Time.Update_HoursPrice(Fixed);
        }
        public bool Delete_FixedPrice(DTO_FixedPrice Fixed)
        {
            return _DAO_Time.Delete_FixedPrice(Fixed);
        }
        public bool Delete_HoursPrice(DTO_HoursPrice Fixed)
        {
            return _DAO_Time.Delete_HoursPrice(Fixed);
        }
    }
}
