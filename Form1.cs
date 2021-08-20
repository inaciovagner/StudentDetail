using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StudentDetail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter stu = new StreamWriter(Application.StartupPath+ "\\Student\\" + textBox1.Text + ".txt");
            stu.WriteLine(label2.Text + ":" + textBox2.Text);
            stu.WriteLine(label3.Text + ":" + textBox3.Text);
            stu.Close();
            MessageBox.Show("File created!!");
        }
    }
}
