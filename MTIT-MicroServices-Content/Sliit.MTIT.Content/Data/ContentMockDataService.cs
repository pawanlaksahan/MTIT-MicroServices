namespace Sliit.MTIT.Content.Data
{
    public class ContentMockDataService
    {

        public static List<Models.Content> Contents = new List<Models.Content>()
        {
            new Models.Content { Id = 1, ProviderName = "Nilusha", Broadcast = "NBA ", Country = "England", Description = "LA Lakers are 2-4 ATS in their last 6 games.", Result = "2-4" },
            new Models.Content { Id = 2, ProviderName = "Krishan", Broadcast = "MLB", Country = "UK", Description = "The total has gone OVER in 6 of Miami's last 6 games when playing on the road against Milwaukee.", Result = "6-0"  },
            new Models.Content { Id = 3, ProviderName = "Sandaka", Broadcast = "NHL", Country = "England" , Description = "Philadelphia are 14-3 SU in their last 17 games against an opponent in the Eastern Conference conference.", Result = "14-3" },
            new Models.Content { Id = 4, ProviderName = "Udaya", Broadcast = "NCAAB", Country = "Australia", Description = "Minnesota are 11-5 ATS in their last 16 games played on a Wednesday.", Result = "11-5"  },
            new Models.Content { Id = 5, ProviderName = "Edmond", Broadcast = "UFC", Country = "UK", Description = "Miami are 8-2 SU in their last 10 games played in April.", Result = "8-2"  }
        };

    }
}
