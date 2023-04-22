using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTHelper.Service.Options
{
    public class ChatGPTOptions
    {
        public string OptionsKey = "ChatGPTOptions";
        public string BaseURL { get; set; }
        public string APIKey { get; set; }
        public string LanguageModel { get; set; }
    }
}
