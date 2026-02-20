using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateGUI
{
    public class RealEstate
    {
        public long Id { get; set; }
        public long CategoryId { get; set; }
        public long SellerId { get; set; }

        public string Description { get; set; } = "";
        public DateTime CreateAt { get; set; }
        public bool FreeOfCharge { get; set; }

        public string ImageUrl { get; set; } = "";
        public int? Area { get; set; }   
        public int Rooms { get; set; }
        public int Floors { get; set; }

        public string LatLong { get; set; } = "";
    }
}
