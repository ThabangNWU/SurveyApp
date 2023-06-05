using System;
using Survey_Application.BLL;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Survey_Application.DAL
{
    class personDAL
    {
        static string myconnstrng = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Moniicah/Desktop/Survey Application/Survey.accdb";
      public bool Insert(personBLL p)
      {
          bool isSuccess = false;
          OleDbConnection conn = new OleDbConnection(myconnstrng);

          try
          {          

               OleDbCommand cmd = conn.CreateCommand();
               conn.Open();
               cmd.CommandText = "INSERT INTO person (personSurname,personFirstNames,personContactNumber,personBirthDate,personAge) VALUES('" + p.personSurname+ "', '"+p.personFirstNames+"','"+ p.personContactNumber+"', '"+ p.personBirthDate+"',"+p.personAge+")";
               cmd.Connection = conn;
               cmd.ExecuteNonQuery();
           
               conn.Close();

              }
              catch(Exception ex)
              {
                  MessageBox.Show(ex.Message);
              }
              finally
              {
                  conn.Close();
              }

              return isSuccess;
      }

      public string Count()
      {
          string count = "";          
          OleDbConnection conn = new OleDbConnection(myconnstrng);
          try
          {
              conn.Open();
              OleDbCommand cmd = new OleDbCommand();
              cmd.Connection = conn;
              string sql = "SELECT COUNT(person_id) FROM person";
              cmd.CommandText = sql;
              OleDbDataReader reader = cmd.ExecuteReader();
              while (reader.Read())
              {
                  count = reader["Count"].ToString();
              }
              conn.Close();
          }
          catch(Exception ex)
          {
              MessageBox.Show(ex.Message);
          }
          finally
          {
              conn.Close();
          }
          



          return count;

      }
   }
}
