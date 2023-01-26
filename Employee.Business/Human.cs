using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Business
{
    public class Human
    {
        public Human()
        {

        }

        public string FetchUpdateText(string id)
        {
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Prem"},
                new Employee { Id = 2, Name = "Ravi"},
            };

            var emp = employees.FirstOrDefault(e => e.Id.ToString() == id);

            return $"Updating it {emp.Name}";
        }

        public string FetchUpdateText2()
        {
            return "Updating it from 2 to 3";
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
