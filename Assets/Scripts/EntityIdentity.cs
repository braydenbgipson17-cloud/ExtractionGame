using UnityEngine;

public class EntityIdentity : MonoBehaviour, IInteractor
{
    [SerializeField] private ItemHandler _itemHandler;

    public ItemHandler ItemHandler => _itemHandler;
}
