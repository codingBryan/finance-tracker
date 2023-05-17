using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_Tracker.Models
{
    public class Income
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public Category Category { get; set; }
        public double amount { get; set; }
        public DateOnly date { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    }
}
