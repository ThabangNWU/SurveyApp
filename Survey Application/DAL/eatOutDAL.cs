using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Survey_Application.BLL;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Survey_Application.DAL
{
    class eatOutDAL
    {
        static string myconnstrng = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Moniicah/Desktop/Survey Application/Survey.accdb";
        public bool Insert(eatOutBLL eat)
        {

            bool isSuccess = false;

            OleDbConnection conn = new OleDbConnection(myconnstrng);

            try
            {

                OleDbCommand cmd = conn.CreateCommand();
                conn.Open();
                cmd.CommandText = "INSERT INTO eat_out(eat_out_rate, person_id,question_id ) VALUES ('" + eat.rate+ "'," + eat.person_id+ "," + eat.question_id + ")";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
               
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
    }
}
