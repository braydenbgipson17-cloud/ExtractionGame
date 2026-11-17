using UnityEngine;

public class TraderBuy : MonoBehaviour, IInteractable
{


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
        if (!interactor.ItemHandler.TryGetItem(ItemID.bandage, out ItemInstance itemToSell))
        {
            return;
        }

        if (!interactor.ItemHandler.TryGetItem(ItemID.wallet, out ItemInstance wallet)) { Debug.LogError("Wallet missing from Inventory setup failed"); return; }

        wallet.TryGetComponent<WalletComponent>(out WalletComponent walletComponent);
        walletComponent.AddCash(itemToSell.ItemData.Price); // hard coded belongs in item data.

        interactor.ItemHandler.RemoveItem(itemToSell);

    }
}
