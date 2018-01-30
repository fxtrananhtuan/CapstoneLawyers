using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAO
{
    public class DAO_Payment:DAO_DataProvider
    {
        public DataTable Load()
        {
            DataSet _DS = new DataSet();
            DataTable tb;
            connect();
            try
            {
                string sql = "select * from Payment";
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

        public string CreateID(string CODE)
        {
            string ID = CreateIDCode(CODE, "Receipt_No", "Payment", 5);
            return ID;
        }

        public bool Insert(DTO_Payment payment)
        {
            connect();

            string sql = "INSERT INTO capston1_customers.Payment (Matter_ID, Receipt_No, Amount, GST, Received, Balance, Description) VALUES (@Matter_ID, @Receipt_No, @Amount, @GST, @Received, @Balance, @Description)";

            try
            {
                _cmd = new MySqlCommand(sql, _cnn);
                _cmd.Parameters.Add("@Matter_ID", MySqlDbType.VarChar, 30).Value = payment.Matter_ID;
                _cmd.Parameters.Add("@Receipt_No", MySqlDbType.Text).Value = payment.Receipt_No;
                _cmd.Parameters.Add("@Amount", MySqlDbType.Decimal).Value = payment.Amount;
                _cmd.Parameters.Add("@GST", MySqlDbType.Decimal).Value = payment.GST;
                _cmd.Parameters.Add("@Received", MySqlDbType.Text).Value = payment.Received;
                _cmd.Parameters.Add("@Balance", MySqlDbType.Text).Value = payment.Balance;
                _cmd.Parameters.Add("@Description", MySqlDbType.Text).Value = payment.Description;
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

        public bool Update(DTO_Payment payment)
        {
            connect();

            string sql = "UPDATE  capston1_customers.Payment SET  Amount=@Amount,GST =@GST, Received=@Received, Balance=@Balance, Description =@Description  WHERE  Matter_ID =  @Matter_ID";

            try
            {
                _cmd = new MySqlCommand(sql, _cnn);
                _cmd = new MySqlCommand(sql, _cnn);
                _cmd.Parameters.Add("@Matter_ID", MySqlDbType.VarChar, 30).Value = payment.Matter_ID;
                _cmd.Parameters.Add("@Amount", MySqlDbType.Decimal).Value = payment.Amount;
                _cmd.Parameters.Add("@GST", MySqlDbType.Decimal).Value = payment.GST;
                _cmd.Parameters.Add("@Received", MySqlDbType.Text).Value = payment.Received;
                _cmd.Parameters.Add("@Balance", MySqlDbType.Text).Value = payment.Balance;
                _cmd.Parameters.Add("@Description", MySqlDbType.Text).Value = payment.Description;
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
