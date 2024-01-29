using CS2MarketL.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CS2MarketL
{
    public class ItemProcessor
    {
        public static async Task<SteamItemModel> LoadItem(ReformatedSearch searchedItem)
        {
            //Example of API:
            //GET https://steamcommunity.com/market/priceoverview/?country=NL&currency=3&appid=578080&market_hash_name=Raglan%20T-shirt%20%28Red-White%29

            //This is how the url for the API behaves on the Steam Market. Testing for AK-47 Bloodsport Minimal Wear.
            //https://steamcommunity.com/market/priceoverview/?country=NL&currency=3&appid=730&market_hash_name=AK-47%20%7C%20Bloodsport%20%28Minimal%20Wear%29
            //The engine overrides these values: currency=3 market_hash_name=AK-47 Bloodsport Minimal%20Wear

            string steamUrl;

            steamUrl = $"https://steamcommunity.com/market/priceoverview/?country=NL&currency={searchedItem.Currency}&appid=730&market_hash_name={searchedItem.Name}%20%7C%20{searchedItem.Skin}%20%28{searchedItem.Condition}%29";

            using (HttpResponseMessage steamResponse = await ApiHelper.ApiClient.GetAsync(steamUrl))
            {
                if(steamResponse.IsSuccessStatusCode)
                {
                    SteamItemModel item = await steamResponse.Content.ReadAsAsync<SteamItemModel>();

                    return item;
                }
                else
                {
                    throw new Exception(steamResponse.ReasonPhrase);
                }
            } 
        }
    }
}
