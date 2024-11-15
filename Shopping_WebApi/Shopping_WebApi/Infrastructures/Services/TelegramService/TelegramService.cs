using Shopping_WebApi.Core.Models;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace Shopping_WebApi.Infrastructures.Services.TelegramService
{
    public class TelegramService(
    TelegramBotConfiguration config
    ) : ITelegramService
    {
        private readonly TelegramBotClient _botClient = new TelegramBotClient(config.BotToken);
        private readonly string _channelId = config.ChannelId;

        public async Task SendMessage(string message)
        {
            await _botClient.SendTextMessageAsync(new ChatId(_channelId), message);
        }
    }

}
