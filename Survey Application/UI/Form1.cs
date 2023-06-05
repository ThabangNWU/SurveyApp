using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;
using Survey_Application.BLL;
using Survey_Application.DAL;

namespace Survey_Application.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*Form1 myform = new Form1();
            myform.StartPosition = FormStartPosition.CenterScreen;*/
            //myform.Show();
        }
        personDAL dal = new personDAL();
        resultDAL dal1 = new resultDAL();
        private void Form1_Load(object sender, EventArgs e)
        {
           
          
            lblCount.Text = dal1.countSurvey();

            double avg = Math.Round(double.Parse(dal1.avgAge()),1) ;
            lblAvg.Text =  avg.ToString();
            lblOldest.Text = dal1.MaxAge();
            lblYoungest.Text = dal1.MinAge();
            lblEatOut.Text = dal1.avgEatOutAge();
            lblMovies.Text = dal1.avgMovies();
            lblWatchTv.Text = dal1.avgTV();
            lblRadio1.Text = dal1.avgRadio();

            string foods = dal1.FoodPecentage();
            int countOccurencesPap = Regex.Matches(foods, "Pap and Wors").Count;
            int countOccurencesPizza = Regex.Matches(foods, "Pizza").Count;
            int countOccurencePasta = Regex.Matches(foods, "Pasta").Count;

           

            int totalSurvey =int.Parse(dal1.countSurvey());

          

            double percentPapAndWors = Math.Round((100 *(double) countOccurencesPap) / totalSurvey, 1);
            
            percentagePapAndWors.Value = (int)percentPapAndWors;
            percentagePizza.Value = (int)Math.Round((100 * (double)countOccurencesPizza) / totalSurvey, 1);
            percentagePasta.Value = (int)Math.Round((100 *(double) countOccurencePasta) / totalSurvey, 1);

            //bunifuCircleProgress1.Value = dal1.FoodPecentage();

            
        }

        private void bunifuSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuCircleProgress3_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Form2 myform = new Form2();
            myform.Show();
            //this.Close();

           
        }
    }
}
