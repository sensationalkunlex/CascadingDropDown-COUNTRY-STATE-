using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CascadingDropDown.Models
{
    public class Country
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public List<State> state { get; set;}
    }
}