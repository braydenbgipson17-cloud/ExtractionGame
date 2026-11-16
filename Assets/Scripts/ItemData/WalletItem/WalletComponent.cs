using UnityEngine;

public class WalletComponent : IItemComponent
{
    private float _cash;

    public float Cash => _cash;

    public void AddCash(float cash)
    {
        if (cash <= 0) { Debug.LogWarning("Chash to add was 0 or less"); return; }
        _cash += cash;
    }

    public bool SubtractCash(float cash)
    {
        if(cash <= 0 || cash > _cash) { return false; } // need to fail more clear later

        _cash -= cash;
        return true;
    }
}
