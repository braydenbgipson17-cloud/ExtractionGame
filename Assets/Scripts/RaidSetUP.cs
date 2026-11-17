using UnityEngine;

public class RaidSetUP : MonoBehaviour
{
    [SerializeField]private LootableContainer _lootableContainer;
    [SerializeField]private ItemDatabase _itemDatabase;
    private ItemFactory _itemFactory;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _itemDatabase.BuildLookUP();
         _itemFactory = new ItemFactory(_itemDatabase);
        _lootableContainer.SetLoot(_itemFactory.BuildItem(ItemID.bandage));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
