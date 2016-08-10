using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_SoftServe
{
    public class Employee
    {
        //Employee's information
        private string name;
        private string email;
        private string phone;
        private string money;
        private string address;
        //Creates the employee by name only
        public Employee(string name)
        {
            this.name = name;

        }
        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }
        public string Money
        {
            get { return this.money; }
            set { this.money = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }



        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(String.Format("Emplyee's name {0}", this.Name));

            return sb.ToString();
        }
    }

}
