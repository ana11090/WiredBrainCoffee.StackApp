using WiredBrainCoffee.StorageApp.Data;
using WiredBrainCoffee.StorageApp.Entities;

using WiredBrainCoffee.StorageApp.Repositories;
 
var employeeRepository = new SqlRepository<Employee>(new StorageAppDbContext());

employeeRepository.Add(new Employee { FirstName = "Julia" });
employeeRepository.Add(new Employee { FirstName = "Robert" });
employeeRepository.Add(new Employee { FirstName = "Alexa" });
employeeRepository.Save();

var items = employeeRepository.GetAll();    
foreach (var item in items)
{
    Console.WriteLine(item);
}

var organizationRepository = new ListRepository<Organization>();
organizationRepository.Add(new Organization { Name = "Non-profit" });
organizationRepository.Save();

var employee = employeeRepository.GetById(2);
Console.WriteLine($"Employee with id 2:{ employee.FirstName}");

IRepository<Organization> repo = new ListRepository<Organization>();

Console.ReadLine();
