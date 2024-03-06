using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiredBrainCoffee.StorageApp.Entities
{
    public class Organization
    {
        public int ID { get; set; }
        public string? Name { get; set; }

        public override string ToString() => $"ID: {ID}, Name: {Name}";
    }


}
