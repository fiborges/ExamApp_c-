using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ExamApp.Controllers
{
    public class VideoHub : Hub
    {
        public async Task SendVideo(string user, string video)
        {
            await Clients.All.SendAsync("ReceiveVideo", user, video);
        }

        public async Task SendAudio(string user, string audio)
        {
            await Clients.All.SendAsync("ReceiveAudio", user, audio);
        }
    }
}
