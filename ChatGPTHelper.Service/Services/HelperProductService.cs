using ChatGPTHelper.Service.Contracts.Models;
using ChatGPTHelper.Service.DTOs;
using ChatGPTHelper.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTHelper.Service.Services
{
    public class HelperProductService : IHelperProductSerivce
    {
        private readonly IBotAPIService _botAPIService;

        public HelperProductService(IBotAPIService botAPIService)
        {
            this._botAPIService= botAPIService;
        }

        public async Task<HelperProductResponseModel> GenerateHelperContent(CustomerRequestModel input)
        {
            if (string.IsNullOrEmpty(input.Message))
            {
                return new HelperProductResponseModel
                {
                    Success = false,
                    Content = null
                };
            }

            var userMessage = new GenerateContentDTO
            {
                prompt = input.Message
            };

            var generatedContent = await _botAPIService.GenerateContent(userMessage);

            if (generatedContent.Count == 0)
            {
                return new HelperProductResponseModel
                {
                    Success = false,
                    Content = null
                };
            }

            return new HelperProductResponseModel
            {
                Success = true,
                Content = generatedContent
            };
        }
    }
}
