namespace Sliit.MTIT.Content.Data
{
    public class ContentMockDataService
    {

        public static List<Models.Content> Contents = new List<Models.Content>()
        {
            new Models.Content { Id = 1, Name = "John", Address = "123 Main St", Age = 20 },
            new Models.Content { Id = 2, Name = "Mary", Address = "456 Second Ave", Age = 22 },
            new Models.Content { Id = 3, Name = "Tom", Address = "789 Third St", Age = 21 },
            new Models.Content { Id = 4, Name = "Kate", Address = "321 Fourth Ave", Age = 23 },
            new Models.Content { Id = 5, Name = "Mike", Address = "654 Fifth St", Age = 19 }
        };

    }
}
