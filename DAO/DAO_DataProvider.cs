using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections;
using System.IO;
using DTO;
using System.Diagnostics;

namespace DAO
{
    public class DAO_DataProvider
    {
        string strcnnString = "Server=110.232.141.220;Port=3306;Database=capston1_customers;Uid=capston1_admin;Pwd=Anhtuan0605;";
        protected MySqlConnection _cnn;
        protected MySqlDataAdapter _dt;
        protected MySqlCommand _cmd;
        protected void connect()
        {
            _cnn = new MySqlConnection(strcnnString);
            _cnn.Open();
        }
        protected void disconnect()
        { _cnn.Close(); }


        protected string CreateIDCode(string strID, string field, string table, int length)
        {
            try
            {
                this.connect();
                string IDCode = strID + "00000";
                string query = "select max(" + field.Trim() + ") from " + table.Trim() + " where left(" + field.Trim() + "," + strID.Length + ")='" + strID.Trim() + "'";

                this._cmd = new MySqlCommand(query, this._cnn);
                this._cmd.CommandType = System.Data.CommandType.Text;
                MySqlDataReader reader = this._cmd.ExecuteReader();

                while (reader.Read())
                    if (!reader.IsDBNull(0))
                        IDCode = Convert.ToString(reader.GetValue(0));

                IDCode = IDCode.Substring(strID.Length);
                IDCode = "0000000000000000" + Convert.ToString(Convert.ToInt64(IDCode) + 1);
                IDCode = strID + IDCode.Substring(IDCode.Length - length + strID.Length);

                this.disconnect();
                return IDCode;
            }
            catch (Exception ex)
            {
                this.disconnect();
                throw ex;
            }
        }



        public string ReadTXT()
        {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("config.txt");
                string s = "";
                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    s=line;
                    //Read the next line
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();
                return s;
            }
            catch
            {
                return null;
            }
           

        }
        public void WriteTXT(string Path)
        {
            try
            {

                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("config.txt");

                //Write path
                sw.WriteLine(Path);

                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));

        public string Create_folder(string MatterID)
        {
            path = path + "\\CapstoneLawyersData\\" + MatterID;
            try
            {
                // Determine whether the directory exists. 
                if (Directory.Exists(path))
                {
                    return "That path exists already.";
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
               return string.Format("The directory was created successfully at {0}.", Directory.GetCreationTime(path));

                // Delete the directory.
                // di.Delete();
                // Console.WriteLine("The directory was deleted successfully.");
            }
            catch (Exception e)
            {
                return string.Format("The process failed: {0}", e.ToString());
            }
            finally { }
        }

        public List<int> getRunningProcesses()
        {
            List<int> ProcessIDs = new List<int>();
            //here we're going to get a list of all running processes on
            //the computer
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (Process.GetCurrentProcess().Id == clsProcess.Id)
                    continue;
                if (clsProcess.ProcessName.Contains("WINWORD"))
                {
                    ProcessIDs.Add(clsProcess.Id);
                }
            }
            return ProcessIDs;
        }

        public void killProcesses(List<int> processesbeforegen, List<int> processesaftergen)
        {
            foreach (int pidafter in processesaftergen)
            {
                bool processfound = false;
                foreach (int pidbefore in processesbeforegen)
                {
                    if (pidafter == pidbefore)
                    {
                        processfound = true;
                    }
                }

                if (processfound == false)
                {
                    Process clsProcess = Process.GetProcessById(pidafter);
                    clsProcess.Kill();
                }
            }
        }

    }

}
