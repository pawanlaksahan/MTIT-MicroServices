namespace Sliit.MTIT.Content.Services
{
    public interface IContentService
    {
        List<Models.Content> GetContents();
        Models.Content? GetContent(int id);
        Models.Content? AddContent(Models.Content content);
        Models.Content? UpdateContent(Models.Content content);
        bool? DeleteContent(int id);
    }
}
