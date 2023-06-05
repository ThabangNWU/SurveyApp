using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Survey_Application.BLL;
using System.Windows.Forms;

namespace Survey_Application.DAL
{
    class moviesDAL
    {
        static string myconnstrng = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Moniicah/Desktop/Survey Application/Survey.accdb";
        public bool Insert(movieBLL movie)
        {
            bool isSuccess = false;
            OleDbConnection conn = new OleDbConnection(myconnstrng);

            try
            {

                OleDbCommand cmd = conn.CreateCommand();
                conn.Open();
                cmd.CommandText = "INSERT INTO watch_movies(watch_movies_rate, person_id,question_id ) VALUES ('" + movie.rate + "'," + movie.person_id + "," + movie.question_id + ")";
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
