using Sliit.MTIT.Content.Data;
using Sliit.MTIT.Content.Models;

namespace Sliit.MTIT.Content.Services
{
    public class ContentService:IContentService
    {
        public List<Models.Content> GetContents()
        {
            return ContentMockDataService.Contents;
        }

        public Models.Content? GetContent(int id)
        {
            return ContentMockDataService.Contents.FirstOrDefault(x => x.Id == id);
        }

        public Models.Content? AddContent(Models.Content content)
        {
            ContentMockDataService.Contents.Add(content);
            return content;
        }

        public Models.Content? UpdateContent(Models.Content content)
        {
            Models.Content selectedContent = ContentMockDataService.Contents.FirstOrDefault(x => x.Id == content.Id);
            if (selectedContent != null)
            {
                selectedContent.Broadcast = content.Broadcast;
                selectedContent.Country = content.Country;
                selectedContent.ProviderName = content.ProviderName;
                selectedContent.Description = content.Description;
                selectedContent.Result = content.Result;
                return selectedContent;
            }

            return selectedContent;
        }

        public bool? DeleteContent(int id)
        {
            Models.Content selectedContent = ContentMockDataService.Contents.FirstOrDefault(x => x.Id == id);
            if (selectedContent != null)
            {
                ContentMockDataService.Contents.Remove(selectedContent);
                return true;
            }
            return false;
        }

    }
}
