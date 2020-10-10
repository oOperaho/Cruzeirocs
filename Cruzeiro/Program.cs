using System;
using System.Threading.Tasks;
using DSharpPlus;

namespace MyFirstBot
{
    class Program
    {
        static DiscordClient discord;

        static void Main(string[] args)
        {
            MainAsync(args).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        static async Task MainAsync(string[] args)
        {
            discord = new DiscordClient(new DiscordConfiguration
            {
                Token = "NzYzODk1MDg3MTkyNzM1NzQ0.X3-WvQ.zWV014RQ6VI40eOL5RDSZ4XH_wI",
                TokenType = TokenType.Bot
            });
            await discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}
