namespace WiredBrainCoffee.StorageApp.Entities
{
    public class Employee : EntityBase
    { 
        public string? FirstName { get; set; }

        public override string ToString() => $"ID: {ID}, FirstName: {FirstName}";

    }
}
