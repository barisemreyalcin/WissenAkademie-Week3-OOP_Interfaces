// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using InterfaceSample;
Console.WriteLine("----------------- MANAGER INFO -----------------");

Manager manager = new Manager();
manager.Id = 1;
manager.FirstName = "Jax";
manager.LastName = "Teller";
manager.Department = "Foreign Trade";
manager.Salary = 75000;
manager.StaffCount = 10;
string managerInfo = manager.getManagerInfo();

Console.WriteLine(managerInfo);

Console.WriteLine(new string('*', 100));

Console.WriteLine("----------------- EMPLOYEE INFO -----------------");
Employee employee = new Employee();
employee.Id = 10;
employee.FirstName = "Jax";
employee.LastName = "Teller";
employee.Department = "IT";
employee.Salary = 25000;
employee.ManagerId = 1;
string employeeInfo = employee.GetEmployeeInfo();

Console.WriteLine(employeeInfo);
