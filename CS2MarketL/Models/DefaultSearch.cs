using CS2MarketL.Enums;

namespace CS2MarketL.Models
{
    public class DefaultSearch
    {
        public string Name { get; set; }

        public string Skin { get; set; }

        public Condition Condition { get; set; }

        public Currency Currency { get; set; }

        public DefaultSearch(string name, string skin, Condition condition, Currency currency)
        {
            Name = name;
            Skin = skin;
            Condition = condition;
            Currency = currency;
        }
    }
}
