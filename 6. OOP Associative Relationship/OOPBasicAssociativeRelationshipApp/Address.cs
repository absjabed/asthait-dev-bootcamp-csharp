using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicAssociativeRelationshipApp
{
    class Address
    {
        public string HouseNo { get; set; }
        public string RoadNo { get; set; }
        public string PostCode { get; set; }
        public string Area { get; set; }
        public string Thana { get; set; }


        public string GetFullAddress()
        {
            return "House No: " + HouseNo + ", Road No: " + RoadNo + ", Post Code: " + PostCode + ", Area: " + Area +
                   ", Thana: " + Thana;
        }

    }
}
