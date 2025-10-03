using ProgrammingInCSharp0407.Panel.Abstarctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp0407.Panel.Models
{
    internal class WatchList : BaseEntity
    {
        public User User { get; set; }
        public Product Product { get; set; }
        public string Description { get; set; }
    }
}
