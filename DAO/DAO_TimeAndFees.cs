using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class DAO_TimeAndFees:DAO_DataProvider
    {
        public DataTable LoadFixedPrice(string Matter)
        {
            DataSet _DS = new DataSet();
            DataTable tb;
            connect();
            try
            {
                string sql = "select * from FixedPrice Where Matter_ID ='"+Matter+"'";
                _cmd = new MySqlCommand(sql, _cnn);
                _dt = new MySqlDataAdapter(_cmd);
                _dt.Fill(_DS);
                _cmd.Dispose();
                tb = _DS.Tables[0];
                disconnect();
            }
            catch (Exception ex)
            {
                disconnect();

                throw ex;
            }
            return tb;
        }

        public DataTable LoadHoursPrice(string Matter)
        {
            DataSet _DS = new DataSet();
            DataTable tb;
            connect();
            try
            {
                string sql = "select * from HoursPrice Where Matter_ID ='" + Matter + "'";
                _cmd = new MySqlCommand(sql, _cnn);
                _dt = new MySqlDataAdapter(_cmd);
                _dt.Fill(_DS);
                _cmd.Dispose();
                tb = _DS.Tables[0];
                disconnect();
            }
            catch (Exception ex)
            {
                disconnect();

                throw ex;
            }
            return tb;
        }

        public DataTable Load(string _sqp)
        {
            DataSet _DS = new DataSet();
            DataTable tb;
            connect();
            try
            {
                string sql = _sqp;
                _cmd = new MySqlCommand(sql, _cnn);
                _dt = new MySqlDataAdapter(_cmd);
                _dt.Fill(_DS);
                _cmd.Dispose();
                tb = _DS.Tables[0];
                disconnect();
            }
            catch (Exception ex)
            {
                disconnect();

                throw ex;
            }
            return tb;
        }

        public string CreateID_Hour(string CODE)
        {
            string ID = CreateIDCode(CODE, "No", "HoursPrice", 5);
            return ID;
        }
        public string CreateID_FixedPrice(string CODE)
        {
            string ID = CreateIDCode(CODE, "No", "FixedPrice", 5);
            return ID;
        }

        public bool Insert_FixedPrice(DTO_FixedPrice Fixed)
        {
            connect();

            string sql = "INSERT INTO capston1_customers.FixedPrice (No,Matter_ID, Date, Description, Amount) VALUES (@No,@Matter_ID, @Date, @Description, @Amount)";

            try
            {
                _cmd = new MySqlCommand(sql, _cnn);
                _cmd.Parameters.Add("@No", MySqlDbType.VarChar).Value = Fixed.No;
                _cmd.Parameters.Add("@Matter_ID", MySqlDbType.VarChar, 30).Value = Fixed.Matter_ID;
                _cmd.Parameters.Add("@Amount", MySqlDbType.Decimal).Value = Fixed.Amount;
                _cmd.Parameters.Add("@Date", MySqlDbType.Text).Value = Fixed.Date;
                _cmd.Parameters.Add("@Description", MySqlDbType.Text).Value = Fixed.Description;
                _cmd.ExecuteNonQuery();
                _cmd.Dispose();
                disconnect();
            }
            catch (Exception ex)
            {
                disconnect();
                return false;
                throw ex;
            }
            return true;
        }

        public bool Insert_HoursPrice(DTO_HoursPrice Fixed)
        {
            connect();

            string sql = "INSERT INTO capston1_customers.HoursPrice (No,Matter_ID, Date, Description, Hours) VALUES (@No,@Matter_ID, @Date, @Description, @Hours)";

            try
            {
                _cmd = new MySqlCommand(sql, _cnn);
                _cmd.Parameters.Add("@No", MySqlDbType.VarChar).Value = Fixed.No;
                _cmd.Parameters.Add("@Matter_ID", MySqlDbType.VarChar, 30).Value = Fixed.Matter_ID;
                _cmd.Parameters.Add("@Hours", MySqlDbType.Decimal).Value = Fixed.Hours;
                _cmd.Parameters.Add("@Date", MySqlDbType.Text).Value = Fixed.Date;
                _cmd.Parameters.Add("@Description", MySqlDbType.Text).Value = Fixed.Description;
                _cmd.ExecuteNonQuery();
                _cmd.Dispose();
                disconnect();
            }
            catch (Exception ex)
            {
                disconnect();
                return false;
                throw ex;
            }
            return true;
        }


        public bool Update_FixedPrice(DTO_FixedPrice Fixed)
        {
            connect();

            string sql = "UPDATE  capston1_customers.FixedPrice SET  Amount=@Amount,Date =@Date, Description=@Description WHERE  No =  @No";

            try
            {
                _cmd = new MySqlCommand(sql, _cnn);
                _cmd.Parameters.Add("@No", MySqlDbType.VarChar).Value = Fixed.No;
                _cmd.Parameters.Add("@Amount", MySqlDbType.Decimal).Value = Fixed.Amount;
                _cmd.Parameters.Add("@Date", MySqlDbType.Text).Value = Fixed.Date;
                _cmd.Parameters.Add("@Description", MySqlDbType.Text).Value = Fixed.Description;
                _cmd.ExecuteNonQuery();
                _cmd.Dispose();
                disconnect();
            }
            catch (Exception ex)
            {
                disconnect();
                return false;
                throw ex;
            }
            return true;
        }

        public bool Update_HoursPrice(DTO_HoursPrice Fixed)
        {
            connect();

            string sql = "UPDATE  capston1_customers.HoursPrice SET  Hours=@Hours,Date =@Date, Description=@Description WHERE  No =  @No";

            try
            {
                _cmd = new MySqlCommand(sql, _cnn);
                _cmd.Parameters.Add("@No", MySqlDbType.VarChar).Value = Fixed.No;
                _cmd.Parameters.Add("@Hours", MySqlDbType.Decimal).Value = Fixed.Hours;
                _cmd.Parameters.Add("@Date", MySqlDbType.Text).Value = Fixed.Date;
                _cmd.Parameters.Add("@Description", MySqlDbType.Text).Value = Fixed.Description;
                _cmd.ExecuteNonQuery();
                _cmd.Dispose();
                disconnect();
            }
            catch (Exception ex)
            {
                disconnect();
                return false;
                throw ex;
            }
            return true;
        }

        public bool Delete_FixedPrice(DTO_FixedPrice Fixed)
        {
            connect();

            string sql = "DELETE FROM FixedPrice WHERE  No =  @No";

            try
            {
                _cmd = new MySqlCommand(sql, _cnn);
                _cmd.Parameters.Add("@No", MySqlDbType.VarChar).Value = Fixed.No;
                _cmd.ExecuteNonQuery();
                _cmd.Dispose();
                disconnect();
            }
            catch (Exception ex)
            {
                disconnect();
                return false;
                throw ex;
            }
            return true;
        }
        public bool Delete_HoursPrice(DTO_HoursPrice Fixed)
        {
            connect();

            string sql = "DELETE FROM HoursPrice WHERE  No =  @No";

            try
            {
                _cmd = new MySqlCommand(sql, _cnn);
                _cmd.Parameters.Add("@No", MySqlDbType.VarChar).Value = Fixed.No;
                _cmd.ExecuteNonQuery();
                _cmd.Dispose();
                disconnect();
            }
            catch (Exception ex)
            {
                disconnect();
                return false;
                throw ex;
            }
            return true;
        }

    }
}
