using System.Threading.Tasks;
using Orleans;

namespace Application.Grains
{
    public class Hello : Grain, IHello
    {
        public Task<string> SayHello(string greeting)
        {
            return Task.FromResult($"Grain client said: '{greeting}', so Hello grain says: Hello!");
        }
    }
}
