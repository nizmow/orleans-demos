using System.Threading.Tasks;
using Orleans;

namespace Application.Grains
{
    public interface IHello : IGrainWithIntegerKey
    {
        Task<string> SayHello(string greeting);
    }
}
