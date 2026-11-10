using UnityEngine;

public class LootableContainer : MonoBehaviour, ILootable, IInteractable
{
    [SerializeField] private ItemData _item;
   
    

    void Start()
    {
        enabled = false;
    }

    //later an inventory we fill via loot pools and shtuff

    public void InteractAction(PlayerItemHandler itemHandler)
    {
        itemHandler.AddItem(_item);
    }
}
