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
    class AnswerDAL
    {
        static string myconnstrng = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Moniicah/Desktop/Survey Application/Survey.accdb";
        public bool Insert(Answer answer)
        {

            bool isSuccess = false;

            OleDbConnection conn = new OleDbConnection(myconnstrng);

            try
            {

                OleDbCommand cmd = conn.CreateCommand();
                conn.Open();
                cmd.CommandText = "INSERT INTO answer(answers_text, person_id,question_id ) VALUES ('"+answer.answer_text+"',"+answer.person_id+","+answer.question_id+")";
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
