using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item DataBase", menuName = "ItemDatabase")]
public class ItemDatabase : ScriptableObject
{
   [SerializeField] private List<ItemData> _itemList = new List<ItemData>();

    Dictionary<ItemID, ItemData> _lookup = new Dictionary<ItemID, ItemData>();
   public IReadOnlyList<ItemData> Items => _itemList;

    public void BuildLookUP()
    {
        foreach (ItemData item in _itemList)
        {
            if (_lookup.ContainsKey(item.Id)) { continue; }
            _lookup[item.Id] = item;
        }
    }


    public ItemData Get(ItemID id) => _lookup[id];
}
