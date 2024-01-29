using CS2MarketL.Enums;
using CS2MarketL.Models;

namespace CS2MarketL.Logic
{
    public class Search
    {
        public ReformatedSearch reformatSearch(DefaultSearch search)
        {
            ReformatedSearch reformatedSearch = new ReformatedSearch();

            if(search.Name.Contains(" "))
            {
                search.Name.Replace(" ", "%20");
            }
            reformatedSearch.Name = search.Name;

            if(search.Skin.Contains(" ")) 
            {
                search.Skin.Replace(" ", "%20");
            }
            reformatedSearch.Skin = search.Skin;

            switch (search.Condition)
            {
                case Condition.FN:
                    reformatedSearch.Condition = "Factory%20New";
                    break;

                case Condition.MW:
                    reformatedSearch.Condition = "Minimal%20Wear";
                    break;

                case Condition.FT:
                    reformatedSearch.Condition = "Field-Tested";
                    break;

                case Condition.WW:
                    reformatedSearch.Condition = "Well-Worn";
                    break;

                case Condition.BS:
                    reformatedSearch.Condition = "Battle-Scarred";
                    break;

                default:
                    reformatedSearch.Condition = "Minimal%20Wear";
                    break;
            }

            reformatedSearch.Currency = (int)search.Currency;
            
            return reformatedSearch;
        }
    }
}
