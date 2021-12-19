using System;
using System.Collections.Generic;

namespace GI.FI01.Models
{
    public partial class Smartphones
    {
        public int SmartphoneId { get; set; }
        public string Model { get; set; }
        public int? Price { get; set; }
        public string Link { get; set; }
        public string Shop { get; set; }
    }
}
