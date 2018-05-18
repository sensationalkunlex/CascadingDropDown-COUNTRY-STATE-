using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CascadingDropDown.Models
{
    public class State
    {
        public int StateID { get; set; }
        public int CountryID { get; set; }
        public Country country { get; set; }
        public string StateName { get; set; }
    }
}