using UnityEngine;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private ItemHandler _handler;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InputManager.Instance.OnOpenInventory += DisplayInventory;
    }

    private void OnDestroy() // will be more of a on disable on enable maybe not sure how death works and or travle between scenes work so and if that happens more in the inventory c# brain over evry inventoyr thing
    {
        InputManager.Instance.OnOpenInventory -= DisplayInventory;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void DisplayInventory()//inject dependincy??
    {
        if(_handler.Inventory.Items.Count <= 0)
        {
            Debug.Log("Bag Empty");
        }
        int index = 0;
        foreach (var item in _handler.Inventory.Items)
        {
            index++;
            Debug.Log($"{index}: {item.Name}");
        }
    }
}
