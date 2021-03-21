using VkNet.Model;
using System.Threading.Tasks;
using VkNet.Abstractions;

namespace MttfBot.Interfaces
{
    public interface IBot
    {
        public IVkApi VkApi { get; }

        public Task ProcessRequest(Message callback);
    }
}
