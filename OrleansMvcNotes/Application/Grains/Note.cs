using System.Threading.Tasks;
using Application.State;
using Orleans;

namespace Application.Grains
{
    public class Note : Grain<NoteState>, INote
    {
        public async Task UpdateContent(string content)
        {
            State.Content = content;
            await WriteStateAsync();
        }

        public async Task UpdateTitle(string title)
        {
            State.Title = title;
            await WriteStateAsync();
        }

        public Task<string> GetContent()
        {
            return Task.FromResult(State.Content);
        }

        public Task<string> GetTitle()
        {
            return Task.FromResult(State.Content);
        }
    }
}
