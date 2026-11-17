using UnityEngine;

public class HubBootStrapper : MonoBehaviour
{
    [SerializeField] private ItemDatabase _itemDatabase;
    private ItemFactory _itemFactory;
    [SerializeField] private TraderSell _traderSell;
    //need shop script 


    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _itemDatabase.BuildLookUP();
        _itemFactory = new ItemFactory(_itemDatabase);
        _traderSell.SetItemFactory(_itemFactory);
        Player player = FindAnyObjectByType<Player>();
        ItemHandler itemHandler = player.GetComponent<ItemHandler>();
        if (itemHandler.Inventory.HasGivenWallet) { return; }
        itemHandler.AddItem(_itemFactory.BuildItem(ItemID.wallet));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
