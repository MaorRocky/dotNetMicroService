using System.Threading.Tasks;
using WebApplication1.Dtos;

namespace WebApplication1.SyncDataServices.Http
{
    public interface ICommandDataClient
    {
        Task SendPlatformToCommand(PlatformReadDto platform);
    }
}