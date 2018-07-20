using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public float Cost { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
