using UnityEngine;

public class PlayerItemHandler : MonoBehaviour
{
    private Inventory inventory = new Inventory();

    public void AddItem(ItemData item)
    {
        inventory.AddItem(item);
    }
}
