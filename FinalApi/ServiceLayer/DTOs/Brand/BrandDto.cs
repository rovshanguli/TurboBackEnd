
using ServiceLayer.DTOs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Brand
{
    public class BrandDto
    {
        public string Name { get; set; }
        public List<ModelDto> Models { get; set; }
    }
}
