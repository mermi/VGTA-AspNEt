using System;
using System.Collections.Generic;

namespace Vgta.Data.Models
{
    public partial class typeequipment
    {
        public typeequipment()
        {
            this.equipments = new List<equipment>();
        }

        public int id { get; set; }
        public string typeEq { get; set; }
        public virtual ICollection<equipment> equipments { get; set; }
    }
}
