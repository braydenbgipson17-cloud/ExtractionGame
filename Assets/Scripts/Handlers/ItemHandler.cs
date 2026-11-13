using UnityEngine;

public class ItemHandler : MonoBehaviour
{
    private Inventory inventory = new Inventory();

    public Inventory Inventory => inventory;
    public void AddItem(ItemData item)
    {
        inventory.AddItem(item);
    }

   
}
