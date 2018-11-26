using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.Models
{
    public class MessageViewModel
    {
        public IEnumerable<MessageModel> Messages { get; set; }
        public IEnumerable<ConversationModel> Conversations { get; set; }

    }
}