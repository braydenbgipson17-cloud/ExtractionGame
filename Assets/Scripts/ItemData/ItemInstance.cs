using System.Collections.Generic;
using UnityEngine;

public class ItemInstance 
{
    private ItemData _itemData;
    private List<IItemComponent> _components = new List<IItemComponent>();
    public ItemData ItemData => _itemData;
    public IReadOnlyList<IItemComponent> Components => _components;

    public ItemInstance(ItemData itemData)
    {
        _itemData = itemData;
    }

    public void AddComponent(IItemComponent component)
    {
        if(component == null) { Debug.LogError($"{_itemData.Name} is missing a Component {component}"); return; }
        _components.Add(component); 
    }

}
