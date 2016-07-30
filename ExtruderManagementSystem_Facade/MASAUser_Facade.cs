using ExtruderManagementSystem_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExtruderManagementSystem_Facade
{
    public class MASAUser_Facade : BaseCRUD
    {
        public MASAUser getMASAUserById(string userID)
        {
            string sql = string.Format(@"SELECT [UserID]
                                          ,[UserName]
                                          ,[Passwords]
                                          ,[Description]
                                          ,[Machine]
                                          ,[Group]
                                          ,[Statuss]
                                      FROM [MASA2_DB].[dbo].[MASA_User]
                                      WHERE [UserID] = @0");
            return db.SingleOrDefault<MASAUser>(sql, userID);
        }

        public string getEncrypt(string pass)
        {
            return GetSHA1Hash(pass) + GetMd5Hash(pass);
        }

        private string GetMd5Hash(string pass)
        {
            pass = ReverseString(pass);
            MD5 md5Hash = MD5.Create();
            // Convert the input string to a byte array and compute the hash. 
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(pass));

            // Create a new Stringbuilder to collect the bytes 
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data  
            // and format each one as a hexadecimal string. 
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string. 
            return sBuilder.ToString().ToUpper();
        }

        private string ReverseString(string pass)
        {
            char[] balik = pass.ToCharArray();
            Array.Reverse(balik);
            return new string(balik);
        }

        private string GetSHA1Hash(string pass)
        {
            SHA1 sha1Hash = SHA1.Create();
            // Convert the input string to a byte array and compute the hash. 
            byte[] data = sha1Hash.ComputeHash(Encoding.UTF8.GetBytes(pass));

            // Create a new Stringbuilder to collect the bytes 
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data  
            // and format each one as a hexadecimal string. 
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string. 
            return sBuilder.ToString().ToUpper();
        }
    }
}
