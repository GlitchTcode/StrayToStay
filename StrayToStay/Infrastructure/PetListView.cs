using StrayToStay.Models;

namespace StrayToStay.Infrastructure
{
    public class PetListView
    {
        public IEnumerable<Post> Posts { get; set; } = Enumerable.Empty<Post>();
        public PagingInfo PagingInfo { get; set; } = new();
    }
}
