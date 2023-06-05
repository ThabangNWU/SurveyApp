using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using Survey_Application.BLL;
namespace Survey_Application.DAL
{
    class resultDAL
    {
        static string myconnstrng = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Moniicah/Desktop/Survey Application/Survey.accdb";

        public string countSurvey()
        {
            string countResult = "";
            
            
            OleDbConnection conn = new OleDbConnection(myconnstrng);

            try
            {

                string sql = "SELECT * FROM person";

                OleDbCommand cmd = new OleDbCommand(sql,conn);

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                countResult = dt.Rows.Count.ToString();
 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return countResult;
        }
        public string avgAge()
        {
            string averageAge = "";
            OleDbConnection conn = new OleDbConnection(myconnstrng);

            try
            {

                string sql = "SELECT AVG(personAge) FROM person";
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                var average = cmd.ExecuteScalar();
                averageAge = average.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return averageAge;
        }

       


        public string avgEatOutAge()
        {
            string averageAge = "";
            OleDbConnection conn = new OleDbConnection(myconnstrng);

            try
            {

                string sql = "SELECT ROUND(AVG(eat_out_rate),1) FROM eat_out";
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                var average = cmd.ExecuteScalar();
                averageAge = average.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return averageAge;
        }
        public string avgMovies()
        {
            string averageAge = "";
            OleDbConnection conn = new OleDbConnection(myconnstrng);

            try
            {

                string sql = "SELECT ROUND(AVG(watch_movies_rate),1) FROM watch_movies";
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                var average = cmd.ExecuteScalar();
                averageAge = average.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return averageAge;
        }

        public string avgTV()
        {
            string averageAge = "";
            OleDbConnection conn = new OleDbConnection(myconnstrng);

            try
            {

                string sql = "SELECT ROUND(AVG(watch_tv_rate),1) FROM watch_tv";
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                var average = cmd.ExecuteScalar();
                averageAge = average.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return averageAge;
        }

        public string avgRadio()
        {
            string averageAge = "";
            OleDbConnection conn = new OleDbConnection(myconnstrng);

            try
            {

                string sql = "SELECT ROUND(AVG(listen_radio_rate),1) FROM listen_radio";
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                var average = cmd.ExecuteScalar();
                averageAge = average.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return averageAge;
        }
        public string MaxAge()
        {
            string maxAge = "";
            OleDbConnection conn = new OleDbConnection(myconnstrng);

            try
            {

                string sql = "SELECT MAX(personAge) FROM person";
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                var average = cmd.ExecuteScalar();
                maxAge = average.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return maxAge;
        }

        public string FoodPecentage()
        {
            string maxAge = "";
            OleDbConnection conn = new OleDbConnection(myconnstrng);

            try
            {

                string sql = "SELECT answers_text from answer";
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                OleDbDataReader reader = cmd.ExecuteReader();
                /*var average = cmd.ExecuteScalar();
                maxAge = average.ToString();*/

                while(reader.Read())
                {
                    maxAge += reader["answers_text"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return maxAge;
        }

        public string MinAge()
        {
            string minAge = "";
            OleDbConnection conn = new OleDbConnection(myconnstrng);

            try
            {

                string sql = "SELECT MIN(personAge) FROM person";
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                var average = cmd.ExecuteScalar();
                minAge = average.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return minAge;
        }

        public int personId(filter fil)
        {
            int minAge = 0;
            OleDbConnection conn = new OleDbConnection(myconnstrng);

            try
            {
                string sql = "SELECT personId FROM person WHERE personSurname  = '"+fil.van+"'";
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                var average = cmd.ExecuteScalar();
                minAge = (int)average;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return minAge;
        }
        public int questionId(filter fil)
        {
            int minAge = 0;
            OleDbConnection conn = new OleDbConnection(myconnstrng);

            try
            {

                string sql = "SELECT questions_id FROM questions WHERE questions_text  = '" + fil.vraag + "'";
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                var average = cmd.ExecuteScalar();
                minAge = (int)average;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return minAge;
        }  

    }
}
