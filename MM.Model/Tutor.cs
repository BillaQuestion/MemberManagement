using MM.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MM.Model
{
    public class Tutor
    {
        private ICollection<Consumption> _taughtConsumptions;

        public string Name { get; set; }

        public Gender Gender { get; set; }

        public string ContactNumber { get; set; }

        public string Address { get; set; }

        /// <summary>
        /// 是否是管理员
        /// </summary>
        public bool IsManager { get; set; }

        public ICollection<Consumption> TaughtConsumptions { get { return _taughtConsumptions; } }

        public void DeclareAConsumption(Consumption consumption)
        {
            _taughtConsumptions.Add(consumption);
        }
    }
}