using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

namespace Cruzeiro
{
    class MyCommands
    {
        [Command("olá")]
        public async Task Olá(CommandContext ctx)
        {
            await ctx.RespondAsync($"👋 olá {ctx.User.Mention}!");
        }
    }
}