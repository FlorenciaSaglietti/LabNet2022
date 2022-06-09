using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Data;
using TP3.Entities;

namespace TP3.Logic
{
    public class EmployeesLogic : BaseLogic
    {
        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }

        public void Delete(int iDEmployees)
        {
            var EmployeeAEliminar = context.Employees.Find(iDEmployees);

            context.Employees.Remove(EmployeeAEliminar);
            context.SaveChanges();
        }
    }
}
