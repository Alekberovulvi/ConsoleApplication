using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Models
{
    class Sales
    {
        public int Number { get; set; }
        public int Sum { get; set; }
        SalesItem SalesItem = new SalesItem();
        public DateTime date = new DateTime();
    }
}
