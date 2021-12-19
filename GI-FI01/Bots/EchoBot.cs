using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
//using EchoAzureDBBot.Models;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Linq;
using System;
using GI.FI01.Models;

namespace EchoAzureDBBot.Bots
{
    public class EchoBot : ActivityHandler
    {
        Winterhack123Context context;
        public Winterhack123Context Context { get { return context; } }
        public EchoBot()
        {
            context = new Winterhack123Context();
        }

        public Smartphones FetchEmployeeName(int no)
        {
            Smartphones smartphones;
            try
            {
                smartphones = (from e in Context.Smartphones
                               where e.SmartphoneId == no
                               select e).FirstOrDefault();//Query for employee details with id
            }
            catch (Exception)
            {
                throw;
            }
            return smartphones;
        }

        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            var empNumber =int.Parse(turnContext.Activity.Text);
            Smartphones smartphones = FetchEmployeeName(empNumber);
            var replyText = smartphones.SmartphoneId + ": " + smartphones.Model;
            await turnContext.SendActivityAsync(MessageFactory.Text(replyText, replyText), cancellationToken);
        }

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            var welcomeText = "Hello and welcome! I have connected this bot to Azure DB."; //welcome message
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext.SendActivityAsync(MessageFactory.Text(welcomeText, welcomeText), cancellationToken);
                }
            }
        }
    }
}
