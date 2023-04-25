

namespace Sliit.MTIT.Event.Data
{
    public class EventMockDataService
    {

        public static List<Models.Event> Events = new List<Models.Event>()
        {
            new Models.Event { Id = 1, Name = "Rich League", Country = "Netherlands", Date = "23/12/2023"},
            new Models.Event { Id = 2, Name = "ChampGain", Country = "Russia", Date = "26/03/2023"},
            new Models.Event { Id = 3, Name = "High Hand Horse", Country = "Canada", Date = "14/08/2023"},
            new Models.Event { Id = 4, Name = "Poker Race", Country = "Singapore", Date = "16/06/2023" },
            new Models.Event { Id = 5, Name = "Billy Bet", Country = "654 Fifth St", Date = "05/03/2023"}
        };

    }
}
