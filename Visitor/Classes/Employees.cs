using System;
using System.Collections.Generic;

namespace DoFactory.GangOfFour.Visitor.RealWorld
{

    /// <summary>
    /// The 'ObjectStructure' class
    /// </summary>
    class Employees
    {
        private List<Employee> _employees = new List<Employee>();

        public void Attach(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Detach(Employee employee)
        {
            _employees.Remove(employee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (Employee e in _employees)
            {
                e.Accept(visitor);
            }
            Console.WriteLine();
        }
    }
}
