using ChatGPTHelper.Service.DTOs;
using ChatGPTHelper.Service.Interfaces;
using ChatGPTHelper.Service.Options;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTHelper.Infrastructure.Network
{
    public class BotAPIService : IBotAPIService
    {
        private readonly ChatGPTOptions _chatGPTOptions;

        public BotAPIService(IOptions<ChatGPTOptions> options)
        {
            _chatGPTOptions = options.Value;
        }

        public Task<List<string>> GenerateContent(GenerateRequestDTO input)
        {
            throw new NotImplementedException();
        }
    }
}
