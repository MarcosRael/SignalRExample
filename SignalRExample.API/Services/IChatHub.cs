namespace SignalRExample.API.Services
{
    public interface IChatHub
    {
        Task SendMessage(string user, string message);
    }
}
