using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }

        public Department()
        {
            Employees = new List<Employee>();
        }
        
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        public Employee GetEmployeeById(int id)
        {
            return Employees.Find(x => x.Id == id);
        }
        public void RemoveEmployee(int id)
        {
            Employee employee = Employees.Find(e => e.Id == id);
            if(employee != null)
                Employees.Remove(employee);
        }
    }
}
