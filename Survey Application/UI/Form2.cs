using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey_Application.UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lblMovies_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            surveyForm myform1 = new surveyForm();
            myform1.Show();
            
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Form1 myform = new Form1();
            myform.Show();
           
        }
    }
}
