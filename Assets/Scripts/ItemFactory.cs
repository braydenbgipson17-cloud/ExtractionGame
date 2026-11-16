using System.Collections.Generic;
using UnityEngine;

public class ItemFactory
{
   private ItemDatabase _itemDatabase;

    
    public ItemFactory(ItemDatabase itemDatabase)
    {
        _itemDatabase = itemDatabase;
    }


    public ItemInstance BuildItem(ItemID id)
    {
       ItemData itemToBuild = _itemDatabase.Get(id);
       ItemInstance itemInstance = new ItemInstance(itemToBuild);

       List<IItemComponent> components = BuildComponents(itemToBuild);

        foreach (IItemComponent component in components)
        {
            itemInstance.AddComponent(component);
        }

        return itemInstance;
    }

    List<IItemComponent> BuildComponents(ItemData itemToBuild)
    {
        List<IItemComponent> comps = new List<IItemComponent>();

        foreach (ComponentType comp in itemToBuild.Components)
        {
            switch (comp)
            {
                case ComponentType.Wallet:
                    comps.Add(new WalletComponent());
                    break;
                default:
                    Debug.LogError($"Factory couldnt handle {comp}");
                    break;
            }
        }
        return comps;
    }
}
