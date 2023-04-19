namespace Sliit.MTIT.Content.Data
{
    public class ContentMockDataService
    {

        public static List<Models.Content> Contents = new List<Models.Content>()
        {
            new Models.Content { Id = 1, ProviderName = "John", Broadcast = "123 Main St", Country = "20", Description = "20", Result = "20" },
            new Models.Content { Id = 2, ProviderName = "Mary", Broadcast = "456 Second Ave", Country = "22", Description = "20", Result = "20"  },
            new Models.Content { Id = 3, ProviderName = "Tom", Broadcast = "789 Third St", Country = "21" , Description = "20", Result = "20" },
            new Models.Content { Id = 4, ProviderName = "Kate", Broadcast = "321 Fourth Ave", Country = "23", Description = "20", Result = "20"  },
            new Models.Content { Id = 5, ProviderName = "Mike", Broadcast = "654 Fifth St", Country = "19", Description = "20", Result = "20"  }
        };

    }
}
