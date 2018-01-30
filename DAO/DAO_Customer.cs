using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using DTO;

namespace DAO
{
    public class DAO_Customer:DAO_DataProvider
    {
        public DataTable Load()
        {
            DataSet _DS = new DataSet();
            DataTable tb;
            connect();
            try
            {
                string sql = "select * from Customer where Active=1";
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

        public string CreateID (string CODE)
        {
            string ID = CreateIDCode(CODE, "Matter_ID", "Customer", 9);
            return ID;
        }

        public bool Insert(DTO_Customer Cus)
        {
            connect();

            string sql = "INSERT INTO capston1_customers.Customer(Matter_ID, Matter_Des, Fees, Disbursements, Salutation, FirstName, LastName, Email, Phone, Address1, Address2, Address3, PostCode, State, Comments, Status,Active,Price) VALUES(@Matter_ID, @Matter_Des, @Fees, @Disbursements, @Salutation, @FirstName, @LastName, @Email, @Phone, @Address1, @Address2, @Address3, @PostCode, @State, @Comments, @Status,@Active,@Price)";

            try
            {
                _cmd = new MySqlCommand(sql, _cnn);
                _cmd.Parameters.Add("@Matter_ID", MySqlDbType.VarChar, 30).Value = Cus.Matter_ID;
                _cmd.Parameters.Add("@Matter_Des", MySqlDbType.Text).Value = Cus.Matter_Des;
                _cmd.Parameters.Add("@Fees", MySqlDbType.Decimal).Value =Convert.ToDecimal(Cus.Fees);
                _cmd.Parameters.Add("@Disbursements", MySqlDbType.Decimal).Value = Convert.ToDecimal(Cus.Disbursements);
                _cmd.Parameters.Add("@Salutation", MySqlDbType.Text).Value = Cus.Salutation;
                _cmd.Parameters.Add("@FirstName", MySqlDbType.Text).Value = Cus.FirstName;
                _cmd.Parameters.Add("@LastName", MySqlDbType.Text).Value = Cus.LastName;
                _cmd.Parameters.Add("@Email", MySqlDbType.Text).Value = Cus.Email;
                _cmd.Parameters.Add("@Phone", MySqlDbType.Text).Value = Cus.Phone;
                _cmd.Parameters.Add("@Address1", MySqlDbType.Text).Value = Cus.Address1;
                _cmd.Parameters.Add("@Address2", MySqlDbType.Text).Value = Cus.Address2;
                _cmd.Parameters.Add("@Address3", MySqlDbType.Text).Value = Cus.Address3;
                _cmd.Parameters.Add("@PostCode", MySqlDbType.Text).Value = Cus.PostCode;
                _cmd.Parameters.Add("@State", MySqlDbType.Text).Value = Cus.State;
                _cmd.Parameters.Add("@Comments", MySqlDbType.Text).Value = Cus.Comments;
                _cmd.Parameters.Add("@Status", MySqlDbType.Text).Value = Cus.Status;
                _cmd.Parameters.Add("@Active", MySqlDbType.Int32).Value =Convert.ToInt32(Cus.Active);
                _cmd.Parameters.Add("@Price", MySqlDbType.Int32).Value = Cus.Check;
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

        public bool Update(DTO_Customer Cus)
        {
            connect();

            string sql = "UPDATE  capston1_customers.Customer SET Price=@Price,  Matter_Des=@Matter_Des,Fees =@Fees, Disbursements=@Disbursements, Salutation=@Salutation, FirstName =@FirstName, LastName=@LastName, Email= @Email, Phone = @Phone, Address1= @Address1, Address2= @Address2, Address3= @Address3, PostCode= @PostCode, State = @State, Comments = Comments, Status= @Status  WHERE  Customer.Matter_ID =  @Matter_ID";

            try
            {
                _cmd = new MySqlCommand(sql, _cnn);
                _cmd.Parameters.Add("@Matter_ID", MySqlDbType.VarChar, 30).Value = Cus.Matter_ID;
                _cmd.Parameters.Add("@Matter_Des", MySqlDbType.Text).Value = Cus.Matter_Des;
                _cmd.Parameters.Add("@Fees", MySqlDbType.Decimal).Value = Convert.ToDecimal(Cus.Fees);
                _cmd.Parameters.Add("@Disbursements", MySqlDbType.Decimal).Value = Convert.ToDecimal(Cus.Disbursements);
                _cmd.Parameters.Add("@Salutation", MySqlDbType.Text).Value = Cus.Salutation;
                _cmd.Parameters.Add("@FirstName", MySqlDbType.Text).Value = Cus.FirstName;
                _cmd.Parameters.Add("@LastName", MySqlDbType.Text).Value = Cus.LastName;
                _cmd.Parameters.Add("@Email", MySqlDbType.Text).Value = Cus.Email;
                _cmd.Parameters.Add("@Phone", MySqlDbType.Text).Value = Cus.Phone;
                _cmd.Parameters.Add("@Address1", MySqlDbType.Text).Value = Cus.Address1;
                _cmd.Parameters.Add("@Address2", MySqlDbType.Text).Value = Cus.Address2;
                _cmd.Parameters.Add("@Address3", MySqlDbType.Text).Value = Cus.Address3;
                _cmd.Parameters.Add("@PostCode", MySqlDbType.Text).Value = Cus.PostCode;
                _cmd.Parameters.Add("@State", MySqlDbType.Text).Value = Cus.State;
                _cmd.Parameters.Add("@Comments", MySqlDbType.Text).Value = Cus.Comments;
                _cmd.Parameters.Add("@Status", MySqlDbType.Text).Value = Cus.Status;
                _cmd.Parameters.Add("@Price", MySqlDbType.Int32).Value = Cus.Check;
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

        public bool Delete(DTO_Customer Cus)
        {
            connect();

            string sql = "UPDATE  capston1_customers.Customer SET Active=@Active  WHERE  Customer.Matter_ID =  @Matter_ID";

            try
            {
                _cmd = new MySqlCommand(sql, _cnn);
                _cmd.Parameters.Add("@Matter_ID", MySqlDbType.VarChar, 30).Value = Cus.Matter_ID;
                _cmd.Parameters.Add("@Active", MySqlDbType.Int32).Value = Convert.ToInt32(Cus.Active);
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
