using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace HW5_Employee
{
    public partial class HW5_Employee : Form
    {
        public HW5_Employee()
        {
            InitializeComponent();
        }
        List<ClsEmployee> list = new List<ClsEmployee>();

        private void Reorganize()//改編
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
            listBox1.DataSource = null;
            listBox1.DataSource = list;
        }

        private void HW5_Employee_Load(object sender, EventArgs e)
        {
            list.Add(new ClsEmployee { EmpName = "Joe", HireDate = DateTime.Now, Jobitle = Jobitle.Engineer, Salary = 60000 });
            list.Add(new ClsEmployee { EmpName = "Amber", HireDate = DateTime.Now, Jobitle = Jobitle.Engineer, Salary = 70000 });
            list.Add(new ClsEmployee { EmpName = "Jamie", HireDate = DateTime.Now, Jobitle = Jobitle.Engineer, Salary = 80000 });
            list.Add(new ClsEmployee { EmpName = "Enuice", HireDate = DateTime.Now, Jobitle = Jobitle.Engineer, Salary = 50000 });
            list.Add(new ClsEmployee { EmpName = "Kay", HireDate = DateTime.Now, Jobitle = Jobitle.Engineer, Salary = 50000 });
            list.Add(new ClsEmployee { EmpName = "Mona", HireDate = DateTime.Now, Jobitle = Jobitle.Engineer, Salary = 50000 });
            for (Jobitle j = Jobitle.Manager; j <= Jobitle.Tester; j++)
            { Titlecombo.Items.Add(j); }
            Titlecombo.SelectedIndex = 0;
        }

        private void Addtool_Click(object sender, EventArgs e)
        {
            int salary;
            if (!int.TryParse(Salarytext.Text, out salary))// ! 等於not
            { MessageBox.Show("薪水不想整數??"); }
            ClsEmployee s = new ClsEmployee();
            s.Employees(EMPtext.Text, HiredateTime.Value, salary, (Jobitle)Titlecombo.SelectedIndex);
            list.Add(s);
            MessageBox.Show("加入成功");
            Reorganize();
            EMPtext.Text = ""; Salarytext.Text = "";
        }

        private void Deletetool_Click(object sender, EventArgs e)
        {
            list.RemoveAt(listBox1.SelectedIndex);
            Reorganize();
        }

        private void Searhtool_Click(object sender, EventArgs e)
        {
            bool b = false;
            foreach (ClsEmployee c in list)
            {
                if (c.EmpName == txttool.Text)
                {
                    MessageBox.Show($"{c.EmpName}  Salary:{c.Salary}");
                    b = true;
                }
            }
            if (!b) { MessageBox.Show("無此人"); }
        }

        private void Cleartool_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            listBox1.DataSource = null;
        }

        private void Sorttool_Click(object sender, EventArgs e)
        {
            list.Sort();
            Reorganize();
        }

        private void Autotool_Click(object sender, EventArgs e)
        {
            Reorganize();
        }
    }


}
