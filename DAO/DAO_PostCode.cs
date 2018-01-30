using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_PostCode
    {
        public void Read_Loaction(List<DTO.DTO_PostCode> PostCode)
        {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("Australian.csv");

                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    DTO_PostCode Post = new DTO_PostCode();

                    string[] parts = line.Split(',');
                    Post.Suburb = parts[0].Trim();
                    Post.Code = parts[1].Trim();
                    Post.state = parts[2].Trim();
                    Post.Suburb_state = Post.Suburb + " : " + Post.state;
                    PostCode.Add(Post);
                    //Read the next line
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();
            }
            catch
            {

            }
        }

    }
}
