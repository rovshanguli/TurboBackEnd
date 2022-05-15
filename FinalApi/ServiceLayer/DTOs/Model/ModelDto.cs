using ServiceLayer.DTOs.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Model
{
    public class ModelDto
    {
        public string Name { get; set; }
        public int BrandId { get; set; }
        public BrandDto Brand { get; set; }
    }
}
