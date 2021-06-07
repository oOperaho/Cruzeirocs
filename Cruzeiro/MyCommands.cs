using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System.Linq;

namespace Cruzeiro
{
    class MyCommands
    {
        [Command("olá")]
        public async Task Olá(CommandContext ctx)
        {
            await ctx.RespondAsync($"👋 olá {ctx.User.Mention}");
        }
        [Command("ping")] 
        [Description("Mostrar o Ping atual.")] 
        [Aliases("pong")] 
        public async Task Ping(CommandContext ctx) 
        {
            await ctx.TriggerTypingAsync();

            var emoji = DiscordEmoji.FromName(ctx.Client, ":ping_pong:");

            await ctx.RespondAsync($"{emoji} Pong! Ping: {ctx.Client.Ping}ms");
        }
        [Command("avatar"), Description("Face Reveal")]
        public async Task Avatar(CommandContext ctx)
        {
            await ctx.TriggerTypingAsync();

            var embed = new DiscordEmbedBuilder
            {
                Title = "Avatar",
                ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.HfF5raOp49CoQKQpF8OLZAHaHa%26pid%3DApi&f=1"
            };
            await ctx.RespondAsync(embed: embed);
        }
        [Command("some"), Description("Soma os números dados.")]
        public async Task SomadeNumeros(CommandContext ctx, [Description("Some esses inteiros.")] params int[] args)
        {
            await ctx.TriggerTypingAsync();

            var sum = args.Sum();

            await ctx.RespondAsync($"{sum.ToString("#,##0")}");
        }
        [Command("complementares"), Description("Atividades Complementares.")]
        public async Task AtvComplementares(CommandContext ctx)
        {
            await ctx.TriggerTypingAsync();
            await ctx.RespondAsync("Link para o tutorial de atividades complementares: https://www.kaltura.com/index.php/extwidget/preview/partner_id/1756931/uiconf_id/31364942/entry_id/1_2i4tvsox/embed/auto?&flashvars[streamerType]=auto");
        }         
    }
}



