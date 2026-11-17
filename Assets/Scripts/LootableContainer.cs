using UnityEngine;

public class LootableContainer : MonoBehaviour, ILootable, IInteractable
{
    [SerializeField] private ItemInstance _item;
   
    bool _isLootable;

    void Start()
    {
        _isLootable = false;
    }

    //later an inventory we fill via loot pools and shtuff

    public void InteractAction(IInteractor interactor)
    {
        if (_isLootable)
        {
            interactor.ItemHandler.AddItem(_item);
            _item = null;
        }
    }

    public void SetLootable(bool isLootable)
    {
        _isLootable=isLootable;
    }

    public void SetLoot(ItemInstance loot)
    {
        _item = loot;
    }
}
