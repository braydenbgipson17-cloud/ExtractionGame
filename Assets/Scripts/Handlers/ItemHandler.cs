using UnityEngine;

public class ItemHandler : MonoBehaviour
{
    private Inventory inventory = new Inventory();


   
    public Inventory Inventory => inventory;
    public void AddItem(ItemInstance item)
    {
        inventory.AddItem(item);
    }

    public bool TryGetItem(ItemID itemID, out ItemInstance itemToGet)
    {
        itemToGet = null;
        if (!inventory.TryGetItem(itemID, out var item))
        {
            Debug.Log($"Inventory doesnt have {itemID} item");
            return false;
        }
        else { itemToGet = item; }
        
        return true;
    }

    public void RemoveItem(ItemInstance itemToRemove)
    {
        inventory.RemoveItem(itemToRemove);
    }

    public bool TryGetComponent<T>(ItemID itemID, out T compToGet)
    {
        compToGet = default(T);
        if(!inventory.TryGetComponent<T>(itemID, out T comp)) { Debug.LogError("Dont Have Item For Component"); return false; }
        compToGet = comp;
        return true;
    }
    
}
