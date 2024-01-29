namespace CS2MarketL.Models
{
    public class SteamItemModel
    {
        //The current lowest price at which the item is listed
        public string lowest_price { get; set; }

        //The number of items that has been sold in the last 24 hours (does not exist if volume = 0)
        public string volume { get; set; }
    }
}
