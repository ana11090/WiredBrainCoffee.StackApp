using WiredBrainCoffee.StorageApp.Entities;

using WiredBrainCoffee.StorageApp.Repositories;
 
var employeeRepository = new GenericRepository<Employee>();

employeeRepository.Add(new Employee { FirstName = "Julia" });
employeeRepository.Add(new Employee { FirstName = "Robert" });
employeeRepository.Add(new Employee { FirstName = "Alexa" });
employeeRepository.Save();

var organizationRepository = new GenericRepository<Organization>();
organizationRepository.Add(new Organization { Name = "Non-profit" });
organizationRepository.Save();

var employee = employeeRepository.GetById(2);
Console.WriteLine($"Employee with id 2:{ employee.FirstName}");
Console.ReadLine();
