using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyW.Models
{
    public class Individual
    {
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Born { get; set; }

        public Sex Sex { get; set; }

        public int Heigth { get; set; }

        public string Email { get; set; }  
    }
}