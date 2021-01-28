using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_3.Models
{
    public class Class
    {
        public string Category { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        //Adding a true/False option
        public bool Edited { get; set; }
        public string Lent { get; set; }

        //Limiting number of characters to 25 character length
        [StringLength(25)]
        public string Notes { get; set; }


    }
}
