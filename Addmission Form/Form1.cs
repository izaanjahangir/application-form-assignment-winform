using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addmission_Form
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            string stdName, fname, nic, email, contact, gender, program, qualification;
            stdName = textBox1.Text;
            fname = textBox2.Text;
            nic = textBox3.Text;
            email = textBox4.Text;
            contact = textBox5.Text;
            frm2.label1.Text = "\n Student Name is: " + stdName + "\n Father's Name is: " + fname + "\n Student's NIC is: " + nic + "\n Student Email-Address is: " + email + "\n Student Contact No is: " + contact;
            // FOR GENDER
            if (radioButton1.Checked)
                frm2.label1.Text += "\n Gender is : " + radioButton1.Text;
            if (radioButton2.Checked)
                frm2.label1.Text += "\n Gender is :" + radioButton2.Text;

            // FOR PROGRAMS
            if (checkBox5.Checked)
                frm2.label1.Text += "\n Program is :" + checkBox5.Text;
            if (checkBox6.Checked) 
                frm2.label1.Text += "\n Program is :" + checkBox6.Text;
            if (checkBox7.Checked) 
                frm2.label1.Text += "\n Program is :" + checkBox7.Text;


            // FOR QUALIFICATIONS:
            if (checkBox1.Checked)
                frm2.label1.Text += "\n Qualification is: " + checkBox1.Text;
            if (checkBox2.Checked)                       
                frm2.label1.Text += "\n Qualification is: " + checkBox2.Text;
            if (checkBox3.Checked)                       
                frm2.label1.Text += "\n Qualification is: " + checkBox3.Text;
            if (checkBox4.Checked)                       
                frm2.label1.Text += "\n Qualification is: " + checkBox4.Text;
            frm2.Show();
            this.Hide();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                MessageBox.Show("Please Enter A Valid Number Input ");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                MessageBox.Show("Please Enter A Valid Input ");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
