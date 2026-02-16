using System.;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace work_out_Tracker
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        private void button3_Click(object sender, System.EventArgs e)
        {
			txtExerciseID.Clear();
			txtExerciseName.Clear();
			cmbIntensity.SelectedIndex = -1;
			cmbStatus.SelectedIndex = -1;
		}

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void label5_Click(object sender, System.EventArgs e)
        {

        }

        private void label4_Click(object sender, System.EventArgs e)
        {

        }
    }
}


	