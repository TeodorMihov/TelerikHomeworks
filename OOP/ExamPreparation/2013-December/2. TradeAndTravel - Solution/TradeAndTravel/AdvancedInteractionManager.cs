using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public class AdvancedInteractionManager : InteractionManager
    {
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    item = new Weapon(itemNameString, itemLocation);
                    break;
                case "wood":
                    item = new Wood(itemNameString, itemLocation);
                    break;
                case "iron":
                    item = new Iron(itemNameString, itemLocation);
                    break;
                default:
                    item = base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
                    break;
            }

            return item;
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = null;
            switch (locationTypeString)
            {
                case "forest":
                    location = new Forest(locationName);
                    break;
                case "mine":
                    location = new Mine(locationName);
                    break;
                default:
                    location = base.CreateLocation(locationTypeString, locationName);
                    break;
            }
            return location;
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    HandleGatherInteraction(actor,commandWords[2]);
                    break;
                case "craft":
                    HandleCraftInteraction(actor, commandWords[2],commandWords[3]);
                    break;
                default: base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }

        private void HandleCraftInteraction(Person actor, string craftedItemType,string craftedItemName)
        {
            switch (craftedItemType)
            {
                case "armor":
                    this.CraftArmor(actor, craftedItemName);
                    break;
                case "weapon":
                    this.CraftWeapon(actor, craftedItemName);
                    break;
                default:
                    break;
            }
        }

        private void CraftArmor(Person actor, string craftedItemName)
        {
            var actorInventory = actor.ListInventory();
            if (actorInventory.Any( it => it.ItemType == ItemType.Iron))
            {
                this.AddToPerson(actor, new Armor(craftedItemName));
            }
        }

        private void CraftWeapon(Person actor, string craftedItemName)
        {
            var actorInventory = actor.ListInventory();
            if ((actorInventory.Any(it => it.ItemType == ItemType.Iron) &&
                actorInventory.Any(it => it.ItemType == ItemType.Wood)))
            {
                this.AddToPerson(actor,new Weapon(craftedItemName));
            }
        }

        private void HandleGatherInteraction(Person actor,string gatheredItemName)
        {
            var gatheringLocation = actor.Location as IGatheringLocation;
            
            if (gatheringLocation != null)
            {
                var actorInventory = actor.ListInventory();
                bool hasRequiredItem = actorInventory.Any(it => it
                    .ItemType == gatheringLocation.RequiredItem
                    );

                if (hasRequiredItem)
                {
                    var producedItem = gatheringLocation.ProduceItem(gatheredItemName);
                    this.AddToPerson(actor, producedItem);
                }
            }
        }
    }
}
