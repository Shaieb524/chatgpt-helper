using ChatGPTHelper.Service.DTOs;
using ChatGPTHelper.Service.Interfaces;
using ChatGPTHelper.Service.Options;
using Microsoft.Extensions.Options;
using OpenAI_API;

namespace ChatGPTHelper.Infrastructure.Network
{
    public class BotAPIService : IBotAPIService
    {
        private readonly ChatGPTOptions _chatGPTOptions;

        public BotAPIService(IOptions<ChatGPTOptions> options)
        {
            _chatGPTOptions = options.Value;
        }

        public async Task<List<string>> GenerateContent(GenerateContentDTO generateRequestModel)
        {

            var apiKey = _chatGPTOptions.APIKey;
            var apiModel = _chatGPTOptions.LanguageModel;

            List<string> content = new List<string>();
            string rs = "";

            OpenAIAPI api = new OpenAIAPI(new APIAuthentication(apiKey));

            var completionRequest = new OpenAI_API.Completions.CompletionRequest()
            {
                Prompt = generateRequestModel.prompt,
                Model = apiModel,
                Temperature = 0.5,
                MaxTokens = 100,
                TopP = 1.0,
                FrequencyPenalty = 0.0,
                PresencePenalty = 0.0,

            };

            var result = await api.Completions.CreateCompletionsAsync(completionRequest);
            foreach (var choice in result.Completions)
            {
                rs = choice.Text;
                content.Add(choice.Text);
            }
            return content;
        }
    }
}
