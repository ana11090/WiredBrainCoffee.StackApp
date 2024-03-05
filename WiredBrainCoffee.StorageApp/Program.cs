using WiredBrainCoffee.StorageApp.Entities;

using WiredBrainCoffee.StorageApp.Repositories;
 
var employeeRepository = new EmployeeRepository();

employeeRepository.Add(new Employee { FirstName = "Julia" });
employeeRepository.Add(new Employee { FirstName = "Robert" });
employeeRepository.Add(new Employee { FirstName = "Alexa" });
employeeRepository.Save();
Console.ReadLine();
