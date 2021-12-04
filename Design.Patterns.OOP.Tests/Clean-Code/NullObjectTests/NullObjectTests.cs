using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Design.Patterns.OOP.Tests.Clean_Code.NullObjectTests
{
    public class NullObjectTests
    {
        [Fact]
        public async Task QueryNonExistEmployee_ShouldNotThrowError()
        {
            var employeeDb = new EmployeeDb();

            var employee = employeeDb.FindById(1);

            Assert.Equal(Employee.Null, employee);
        }

        [Fact]
        public async Task QueryExistingEmployee_ShouldReturnIt()
        {
            var employeeDb = new EmployeeDb();

            var employee = employeeDb.FindById(2);

            Assert.NotEqual(Employee.Null, employee);
        }
    }

    public class Employee
    {
        public static readonly Employee Null = new() { Name = string.Empty, Age = -1 };

        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class EmployeeDb
    {
        public Dictionary<int, Employee> Employees { get; private set; } = new();

        public EmployeeDb()
        {
            Employees.Add(2, new Employee { Name = "O", Age = 22 });
            Employees.Add(3, new Employee { Name = "S", Age = 24 });
            Employees.Add(4, new Employee { Name = "K", Age = 25 });
        }

        public Employee FindById(int i)
        {
            if (Employees.TryGetValue(i, out var employee))
                return employee;

            return Employee.Null;
        }
    }
}