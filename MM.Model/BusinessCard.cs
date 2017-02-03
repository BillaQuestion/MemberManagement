using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MM.Model
{
    public class BusinessCard
    {
        #region
        public string Name { get; set; }

        public string Medium { get; set; }

        public int CountOfMedium { get; set; }

        public decimal Cost { get; set; }
        #endregion
    }
}