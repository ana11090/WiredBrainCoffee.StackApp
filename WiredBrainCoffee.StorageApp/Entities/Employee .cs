namespace WiredBrainCoffee.StorageApp.Entities
{
    public class Employee
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }

        public override string ToString() => $"ID: {ID}, FirstName: {FirstName}";

    }
}
