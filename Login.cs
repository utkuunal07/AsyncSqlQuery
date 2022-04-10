using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace RaporsForms
{
    class Login
    {
        public string[] durumveconnectionstring =new string[2];
        public string[] LoginDB(int db , string username, string password)
        {
            
            string connectionString;
            string durum;
            switch (db)
            {
                case 0:
                    connectionString = " Data Source = (DESCRIPTION=" +
    "(ADDRESS =" +
     "(PROTOCOL = TCP)" +
      "(HOST = *********)" +
      "(PORT = *********)" +
    ")" +
    "(CONNECT_DATA =" +
      "(SID = TESTHIS)" +
    ")" +
   ");User Id = " + username + "; password = " + password;

                    break;
                case 1:
                    connectionString = " Data Source = (DESCRIPTION=" +
    "(ADDRESS =" +
      "(PROTOCOL = TCP)" +
      "(HOST = *********)" +
      "(PORT = *********)" +
    ")" +
    "(CONNECT_DATA =" +
      "(SERVER = dedicated)" +
      "(SID = UATATKDB)" +
    ")" +
   ");User Id = " + username + "; password = " + password;
                    break;

                case 2:
                    connectionString = " Data Source = (DESCRIPTION=" +
    "(ADDRESS = " +
      "(PROTOCOL = TCP)" +
      "(HOST = *********)" +
      "(PORT = *********)" +
    ")" +
    "(CONNECT_DATA =" +
      "(SERVICE_NAME = BHISDB)" +
    ")" +
   ");User Id = " + username + "; password = " + password;
                    break;
                case 3:
                    connectionString = " Data Source = (DESCRIPTION=" +
    "(ADDRESS =" +
      "(PROTOCOL = TCP)" +
      "(HOST = *********)" +
      "(PORT = *********)" +
    ")" +
    "(CONNECT_DATA =" +
      "(SID = TESTATK)" +
    ")" +
   ");User Id = " + username + "; password = " + password;
                    break;

                case 4:
                    connectionString = " Data Source = (DESCRIPTION=" +
    "(ADDRESS =" +
      "(PROTOCOL = TCP)" +
      "(HOST = *********)" +
      "(PORT = *********)" +
    ")" +
    "(CONNECT_DATA =" +
      "(SERVER = dedicated)" +
      "(SID = RAPORDB)" +
    ")" +
  ");User Id = " + username + "; password = " + password;
                    break;
                case 5:
                    connectionString = " Data Source = (DESCRIPTION=" +
    "(ADDRESS =" +
      "(PROTOCOL = TCP)" +
      "(HOST = *********)" +
      "(PORT = *********)" +
    ")" +
   "(CONNECT_DATA =" +
      "(SERVER = dedicated)" +
      "(SID = TAKSIMDB)" +
    ")" +
   ");User Id = " + username + "; password = " + password;
                    break;

                case 6:
                    connectionString = " Data Source = (DESCRIPTION=" +
   "(ADDRESS =" +
      "(PROTOCOL = TCP)" +
      "(HOST = *********)" +
      "(PORT = *********)" +
    ")" +
    "(CONNECT_DATA =" +
      "(SERVICE_NAME = KOZDB)" +
    ")" +
  ");User Id = " + username + "; password = " + password;
                    break;

                case 7:
                    connectionString = " Data Source = (DESCRIPTION=" +
    "(ADDRESS =" +
      "(PROTOCOL = TCP)" +
      "(HOST = *********)" +
      "(PORT = *********)" +
    ")" +
   "(CONNECT_DATA =" +
      "(SERVICE_NAME = ATKDB)" +
    ")" +
  ");User Id = " + username + "; password = " + password;
                    break;

                default:
                    connectionString = " Data Source = (DESCRIPTION=" +
    "(ADDRESS =" +
     "(PROTOCOL = TCP)" +
      "(HOST = *********)" +
      "(PORT = *********)" +
    ")" +
    "(CONNECT_DATA =" +
      "(SID = TESTHIS)" +
    ")" +
   ");User Id = " + username + "; password = " + password;
                    break;
            }
                   
            using (var conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    durum = "Bağlantı Başarılı";
                    durumveconnectionstring[0] = durum;
                    durumveconnectionstring[1] = connectionString;
                    return durumveconnectionstring;
                    
                }
                catch (Exception e)
                {
                    durum = "Bağlantı Başarısız";
                    string x=e.Message;
                    durumveconnectionstring[0] = durum;
                    durumveconnectionstring[1] = connectionString;
                    return durumveconnectionstring;
                }
            }

        }
    }
}
