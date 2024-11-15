namespace Shopping_WebApi.Infrastructures.Services.TelegramService
{
    public interface ITelegramService
    {
        Task SendMessage(string message);
    }

}
