using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.App.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? District { get; set; }
        public string? Document { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public int IdCity { get; set; }

    }
}
