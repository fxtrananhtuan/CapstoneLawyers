using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_PostCode
    {
        DAO_PostCode _DAOPostCode = new DAO_PostCode();
        public void ReadLocation (List<DTO_PostCode> PostCode)
        {
            _DAOPostCode.Read_Loaction(PostCode);
        }
    }
}
