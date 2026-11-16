using UnityEngine;

public class HubBootStrapper : MonoBehaviour
{
    [SerializeField] private ItemDatabase _itemDatabase;
    private ItemFactory _itemFactory;

    //need shop script 
    

    //we will do player for now 
   [SerializeField] Player Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _itemDatabase.BuildLookUP();
        _itemFactory = new ItemFactory(_itemDatabase);
        Player.GetComponent<ItemHandler>().AddItem(_itemFactory.BuildItem(ItemID.wallet));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
