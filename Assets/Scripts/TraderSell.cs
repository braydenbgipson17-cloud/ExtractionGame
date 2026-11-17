using UnityEngine;

public class TraderSell : MonoBehaviour, IInteractable
{

    private ItemFactory _itemFactory;

    // pretend List here one item for now
    ItemInstance _instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void OnDestroy()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void InteractAction(IInteractor interactor)
    {
        _instance =_itemFactory.BuildItem(ItemID.medkit);

        if(!interactor.ItemHandler.TryGetComponent<WalletComponent>(ItemID.wallet, out var walletComp)) { Debug.LogError("No Wallet Comp For Trader"); _instance = null; return; }

        if(walletComp.Cash < _instance.ItemData.Price) { Debug.Log("Not enough money"); _instance = null; return; }
        
        walletComp.SubtractCash(_instance.ItemData.Price);
        interactor.ItemHandler.AddItem(_instance);
        _instance = null;


    }

    public void SetItemFactory(ItemFactory itemFactory)
    {
        if (itemFactory == null) { Debug.LogError("Item Factory is null what going on doe" ); return; }
        _itemFactory = itemFactory;
    }
}
