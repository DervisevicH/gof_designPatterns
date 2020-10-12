using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class HeadDepartment
    {       

        private List<Department> childDepartments;
        public HeadDepartment()
        {
           
            this.childDepartments = new List<Department>();
        }

        public void printDepartmentName()
        {
            foreach (var item in childDepartments)
            {
                item.PrintDepartmentName();
            };
        }

        public void addDepartment(Department department)
        {
            childDepartments.Add(department);
        }

        public void removeDepartment(Department department)
        {
            childDepartments.Remove(department);
        }
    }
}
