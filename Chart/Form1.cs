using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //initialize when Form1 is loaded.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Define the border style of the form to a FixedSingle.
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Set the MaximizeBox to false to remove the maximize box.
            this.MaximizeBox = false;

            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        //go to page 2 when user input his name.
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter key is down
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Input your name", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    Globals.user_name = textBox1.Text;
                    Form2 frm = new Form2();
                    frm.Show();
                    this.Hide();
                }
            }
        }
        //get file name for inputting 2 class data
        private void get_2classes_data()
        {
            OpenFileDialog openFileDg = new OpenFileDialog();

            openFileDg.InitialDirectory = System.Windows.Forms.Application.StartupPath + "\\Res";
            openFileDg.Filter = "CSV (*.csv)|*.csv";
            openFileDg.FilterIndex = 2;
            openFileDg.RestoreDirectory = true;
            openFileDg.Multiselect = false;

            if (openFileDg.ShowDialog() == DialogResult.OK)
            {
                Globals.input_2class_filename = openFileDg.FileName;
            }
        }
        //get file name for inputting 4 class data
        private void get_4classes_data()
        {
            OpenFileDialog openFileDg = new OpenFileDialog();

            openFileDg.InitialDirectory = System.Windows.Forms.Application.StartupPath + "\\Res";
            openFileDg.Filter = "CSV (*.csv)|*.csv";
            openFileDg.FilterIndex = 2;
            openFileDg.RestoreDirectory = true;
            openFileDg.Multiselect = false;

            if (openFileDg.ShowDialog() == DialogResult.OK)
            {
                Globals.input_4class_filename = openFileDg.FileName;
            }
        }
        //occur when 2 class button is pressed
        private void get_2class_OnClick(Object sender, EventArgs e)
        {
            get_2classes_data();
        }
        //occur when 4 class button is pressed
        private void get_4class_OnClick(object sender, EventArgs e)
        {
            get_4classes_data();
        }
        //occur when submit button is pressed.
        private void submit_OnClick(object sender, EventArgs e)
        {
            //set user name
            if (textBox1.Text == "")
            {
                MessageBox.Show("Input your name", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Globals.user_name = textBox1.Text;
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
        }
    }
}
