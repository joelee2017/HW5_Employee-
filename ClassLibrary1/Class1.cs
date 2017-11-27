using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public enum Jobitle
    {
        Manager, Engineer, Tester
    }


    public class ClsEmployee : IDisposable, IComparable<ClsEmployee>
    {

        public string EmpName { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public Jobitle Jobitle { get; set; }

        public void Employees(string empname, DateTime hirddate, decimal salary, Jobitle jobtitle)
        {
            EmpName = empname;
            HireDate = hirddate;
            Salary = salary;
            Jobitle = jobtitle;
        }

        public override string ToString()
        {
            return $"Name:{EmpName}, HireDate:{HireDate}, Salary:{Salary}, JobTitle:{Jobitle}";
        }

        public int CompareTo(ClsEmployee other)
        {
            return this.Salary.CompareTo(other.Salary);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        ~ClsEmployee()
        {
            this.Dispose();
        }
    }
}
