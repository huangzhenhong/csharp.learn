using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace csharp.learn.async
{
    public class ImprovedShareService
    {
        private readonly TimeSpan cacheTime = TimeSpan.FromSeconds(2);
        private DateTime lastRun = DateTime.Now;
        private IEnumerable<StockListing> cachedListings;
        public ValueTask<IEnumerable<StockListing>> GetStockDetails()
        {
            async Task<IEnumerable<StockListing>> GetShareDetails()
            {
                cachedListings = await Task.Run(() => new List<StockListing>
                {
                    new StockListing("AAPL", 157.50m, 158.52m, 154.55m,"741,37B"),
                    new StockListing("AMZN", 1473.35m, 1513.47m, 1449.00m,"722,71B"),
                    new StockListing("QCOM", 56.33m, 57.53m, 56.24m, "68,86B")
                });
                lastRun = DateTime.Now;
                return cachedListings;
            }

            if (DateTime.Now - lastRun < cacheTime)
            {
                return new ValueTask<IEnumerable<StockListing>>(cachedListings);
            }
            return new ValueTask<IEnumerable<StockListing>>(GetShareDetails());
        }
    }
}
