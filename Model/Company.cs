using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company_Register_Web_API.Model
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int AnnualNetProfit {get; set;}

        public int NumberOfEmployees { get; set; }



    }
}
