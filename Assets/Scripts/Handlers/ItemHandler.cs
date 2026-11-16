using UnityEngine;

public class ItemHandler : MonoBehaviour
{
    private Inventory inventory = new Inventory();

    public Inventory Inventory => inventory;
    public void AddItem(ItemInstance item)
    {
        inventory.AddItem(item);
    }

   
}
