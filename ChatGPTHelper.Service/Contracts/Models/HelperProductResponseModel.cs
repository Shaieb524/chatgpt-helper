using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTHelper.Service.Contracts.Models
{
    public class HelperProductResponseModel
    {
        public List<string> Content { get; set; }
        public bool Success { get; set; }
    }
}
