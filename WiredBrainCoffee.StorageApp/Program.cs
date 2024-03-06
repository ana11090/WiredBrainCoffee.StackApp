using WiredBrainCoffee.StorageApp.Entities;

using WiredBrainCoffee.StorageApp.Repositories;
 
var employeeRepository = new GenericRepositoryWithRemove<Employee>();

employeeRepository.Add(new Employee { FirstName = "Julia" });
employeeRepository.Add(new Employee { FirstName = "Robert" });
employeeRepository.Add(new Employee { FirstName = "Alexa" });
employeeRepository.Save();

var organizationRepository = new GenericRepository<Organization>();
organizationRepository.Add(new Organization { Name = "Non-profit" });
organizationRepository.Save();

Console.ReadLine();
