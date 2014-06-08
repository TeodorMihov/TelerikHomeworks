namespace TradeAndTravel
{
    public abstract class GatheringLocation : Location, IGatheringLocation
    {
        public GatheringLocation(string name,LocationType type, ItemType gatheredItemType, ItemType requiredItemType)
            :base(name,type)
        {
            this.GatheredType = gatheredItemType;
            this.RequiredItem = requiredItemType;
        }
        public ItemType GatheredType { get; protected set; }

        public ItemType RequiredItem { get; protected set; }

        public abstract Item ProduceItem(string name);
    }
}
