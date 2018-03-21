﻿using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Voltaire.Controllers.Messages;

namespace Voltaire.Modules
{
    public class Messages : ModuleBase<SocketCommandContext>
    {
        public Messages() { }

        [Command("send", RunMode = RunMode.Async)]
        public async Task Send(string channelName, [Remainder] string message)
        {
            await Controllers.Messages.Send.PerformAsync(Context, channelName, message);
        }

        [Command("send_guild", RunMode = RunMode.Async)]
        public async Task SendGuild(string guildName, string channelName, [Remainder] string message)
        {
            await Controllers.Messages.SendToGuild.PerformAsync(Context, guildName, channelName, message);
        }
    }
}