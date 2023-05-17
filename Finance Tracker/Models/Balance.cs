using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_Tracker.Models
{
    internal class Balance
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateOnly date { get; set; }
        public double amount { get; set; }

    }
}
