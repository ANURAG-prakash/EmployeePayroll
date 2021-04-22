using EmployeeManagement;
using EmployeeManagement.Model.Salary_Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace EmployeeManagementTest
{
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSalaryDataAbleToUpdateSalaryDetails()
        {
            Salary salary = new Salary();
            SalaryUpdateModel updateModel = new SalaryUpdateModel()
            {
                salaryId = 2,
                Month = "Jan",
                EmployeeSalary = 1300,
                EmployeeId = 5
            };

            int EmpSalary = salary.UpdateEmployeeSalary(updateModel);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(updateModel.EmployeeSalary, EmpSalary);
        }
    }


}