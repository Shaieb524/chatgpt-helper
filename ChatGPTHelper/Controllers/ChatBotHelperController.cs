using AutoMapper;
using ChatGPTHelper.API.Contracts;
using ChatGPTHelper.Service.Contracts.Models;
using ChatGPTHelper.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChatGPTHelper.API.Controllers
{
    public class ChatBotHelperController : BaseController
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly IHelperProductSerivce _helperProductService;

        public ChatBotHelperController(ILogger logger, IMapper mapper, IHelperProductSerivce helper)
        {
            _logger = logger;
            _mapper = mapper;
            _helperProductService = helper;
        }

        [HttpPost("prompt")]
        public async Task<ActionResult<dynamic>> GenerateChatBotContent([FromBody] GenerateContentRequestContract userInput)
        {
            var generateHelperInput = _mapper.Map<CustomerRequestModel>(userInput);
            var oResponse = await _helperProductService.GenerateHelperContent(generateHelperInput);
            _logger.LogInformation($"Content generated : {oResponse.Content}");

            return oResponse != null ? Ok(oResponse) : UnprocessableEntity("Something went wrong");
        }
    }
}
