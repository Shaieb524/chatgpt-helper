using ChatGPTHelper.Service.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTHelper.Service.Interfaces
{
    public interface IHelperProductSerivce
    {
        Task<HelperProductResponseModel> GenerateHelperContent(CustomerRequestModel input);
    }
}
