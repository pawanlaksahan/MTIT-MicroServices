using System.Reflection;

namespace Sliit.MTIT.Payment.Data
{
    public class PaymentMockDataService
    {

        public static List<Models.Payment> Payments = new List<Models.Payment>()
        {
            new Models.Payment { Id = 1, CardNumber = 889999678, ExpiryDate = "2025/07/23", CVC = 788, Amount = 7000 },
            new Models.Payment { Id = 2, CardNumber = 997788678, ExpiryDate = "2025/09/10", CVC = 344, Amount = 9000 },
            new Models.Payment { Id = 3, CardNumber = 778899075, ExpiryDate = "2024/05/20", CVC = 455, Amount = 8000 },
            new Models.Payment { Id = 4, CardNumber = 778899543, ExpiryDate = "2023/08/15", CVC = 677, Amount = 5000 },
            new Models.Payment { Id = 5, CardNumber = 335566889, ExpiryDate = "2025/05/29", CVC = 555, Amount = 12000 }

        };

    }
}
