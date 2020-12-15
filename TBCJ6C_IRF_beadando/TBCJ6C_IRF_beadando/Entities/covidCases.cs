using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBCJ6C_IRF_beadando.Entities
{
    public class covidCases
    {
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public int cases { get; set; }
        public int death { get; set; }
        public string country { get; set; }
        public Continent continent { get; set; }

    }
}
