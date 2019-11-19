using System.Threading.Tasks;
using Orleans;

namespace Application.Grains
{
    public interface INote : IGrainWithGuidKey
    {
        Task UpdateContent(string content);

        Task UpdateTitle(string title);

        Task<string> GetContent();

        Task<string> GetTitle();
    }
}
