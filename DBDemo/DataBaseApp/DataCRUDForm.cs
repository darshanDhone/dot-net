using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary;

namespace DataBaseApp
{
    public partial class DataCRUDForm : Form
    {
        EmpDataStore dataStore = new EmpDataStore(@"server=(localdb)\MSSQLLocalDB;database=training;Integrated Security=True");
        public DataCRUDForm()
        {
            InitializeComponent();
        }

        private void DataCRUDForm_Load(object sender, EventArgs e)
        {
            dgData.DataSource = dataStore.GetEmps();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSalary.Clear();
            txtEmpno.Clear();
            txtHiredate.Clear();
            txtEmpname.Clear();
        }

        private void btnAddemp_Click(object sender, EventArgs e)
        {
            try
            {
                Emp newEmp = new Emp();
                newEmp.EmpNo = int.Parse(txtEmpno.Text);
                newEmp.EmpName = txtEmpname.Text;
                newEmp.Salary = decimal.Parse(txtSalary.Text);
                newEmp.HireDate = Convert.ToDateTime(txtHiredate.Text);

                int count = dataStore.AddEmp(newEmp);

                if (count==1)
                {
                    MessageBox.Show("Record Inserted");
                    dgData.DataSource = dataStore.GetEmps();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Emp newEmp = new Emp();
                newEmp.EmpNo = int.Parse(txtEmpno.Text);
                newEmp.EmpName = txtEmpname.Text;
                newEmp.Salary = decimal.Parse(txtSalary.Text);
                newEmp.HireDate = Convert.ToDateTime(txtHiredate.Text);

                int count = dataStore.EditEmp(newEmp);

                if (count == 1)
                {
                    MessageBox.Show("Record Updated");
                    dgData.DataSource = dataStore.GetEmps();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int empno = int.Parse(txtEmpno.Text);
                Emp emp = dataStore.SearchEmployee(empno);

                txtEmpname.Text = emp.EmpName;
                txtHiredate.Text = emp.HireDate.ToString();
                txtSalary.Text = emp.Salary.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
