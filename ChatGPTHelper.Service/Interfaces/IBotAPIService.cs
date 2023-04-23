using ChatGPTHelper.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTHelper.Service.Interfaces
{
    public interface IBotAPIService
    {
        Task<List<string>> GenerateContent(GenerateContentDTO input);
    }
}
