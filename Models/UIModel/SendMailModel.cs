using System;
using System.Collections.Generic;
using System.Text;

namespace Models.UIModel
{
    public class SendMailModel
    {

        public List<string> To { get; set; }

        public List<string> Cc { get; set; }
        public List<string> Bbc { get; set; }

        public string Template { get; set; }

        public string Subject { get; set; }
        public bool IsHtml { get; set; }

        public List<string> Attactments { get; set; }

    }
}
