using EFAssignment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrainingContext db = new TrainingContext();
            try
            {
                string username = textBox1.Text;
                string password = textBox2.Text;

                Userdatum userdatum = db.Userdata.SingleOrDefault(u => u.Username == username && u.Password == password);
                if (userdatum!=null)
                {
                    label3.Text = "Valid";
                }
                else
                {
                    label3.Text = "Invalid";
                }
            }
            catch (Exception)
            {

                throw;
            }
            
            
            //Console.WriteLine(userdatum);

        }
    }
}
