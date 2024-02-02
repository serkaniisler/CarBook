using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookDomain.Entities
{
    public class CarDescription
    {
        [Key]

        public int DescriptionID { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public string  Details { get; set; }

    }
}
