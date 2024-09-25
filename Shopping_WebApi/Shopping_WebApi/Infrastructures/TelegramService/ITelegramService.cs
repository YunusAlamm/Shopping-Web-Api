namespace Shopping_WebApi.Infrastructures.TelegramService
{
    public interface ITelegramService
    {
        Task SendMessage(string message);
    }

}
