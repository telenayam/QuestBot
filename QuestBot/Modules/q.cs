using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace QuestBot.Modules
{
    public class q : ModuleBase<SocketCommandContext>
    {

        int n = 5;

        [Command("c")]
        public async Task PingAsyncC()
        {
            string[] quests = { "Might", "Resource", "Troops", "Monster", "Construction", "Troops", "Monster", "Resource", "Research", "Troops", "Monster" };
            await ReplyAsync($"**Hello {Context.User.Mention}, Current Quest:" + quests[n] +"**");
        }

        [Command("n")]
        public async Task PingAsyncN()
        {
            string[] quests = { "Might", "Resource", "Troops", "Monster", "Construction", "Troops", "Monster", "Resource", "Research", "Troops", "Monster" };
            await ReplyAsync($"**Hello {Context.User.Mention}, Next Quest:" + quests[n+1] +"**");
        }

        [Command("l")]
        public async Task PingAsyncL()
        {
            string[] quests = { "Might", "Resource", "Troops", "Monster", "Construction", "Troops", "Monster", "Resource", "Research", "Troops", "Monster" };
            await ReplyAsync("**Current: " + quests[4] + " ** > " + quests[5] + " > " + quests[6] + " > " + quests[7] + " > " + quests[8] + " > " + quests[9] + " > " + quests[10] + " > " + quests[0] + " > " + quests[1] + " > " + quests[2] + " > " + quests[3]);
        }

        [Command("h")]
        public async Task PingAsyncH()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("List Of Commands:", "!h for help")
            .AddInlineField("!c", "Show the current Solo Quest")
            .AddInlineField("!n", "Show the next Solo Quest")
            .AddInlineField("!l", "Show the overall list of Solo Quest");

            await ReplyAsync("", false, builder.Build());
        }


    }

}
