using System.Collections.Generic;
using UnityEngine;

public class Inventory //persistant thing
{
    private List<ItemData> _items = new List<ItemData>();
    public IReadOnlyList<ItemData> Items => _items; //items will be A. instances later and B. need to find a way to make all items one thing to store my going theory is when we use or equip an item we need to cast it out or back into something 

    private float _baseCarryWeight = 30f; // carry weight regaurdless of backpack backpacks will increase carry weight ex 30 base + 20 from bag = 50kg now 

    private float _currentMaxCarryWeight;

    private float _currentCarryWeight;
    public float BaseCarryWeight => _baseCarryWeight;

    public Inventory()// i should add the ablilty to add a starting inventory here i just dont know how to make nullable params then if we have starting inven total weight apply 
    {
        _currentMaxCarryWeight = _baseCarryWeight;
    }

    public void AddItem(ItemData item)
    {
        if(item == null) { Debug.LogWarning("Item was null"); return; }
        _items.Add(item);
        Debug.Log($"Item added: {item.Name}");
    }

}
