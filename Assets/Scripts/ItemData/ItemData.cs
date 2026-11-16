using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Item", menuName = "ItemData")]

public class ItemData : ScriptableObject
{
    
    [SerializeField] private string _name;
    [SerializeField] private string _description;
    [SerializeField] private ItemID _id;
    [SerializeField] private List<ComponentType> _components;
    //weight
    //catigory?? 
    //gameobject prefab

    //[SerializeField] private Image icon;


    public string Name => _name;
    public string Description => _description;
    public ItemID Id => _id;
    public IReadOnlyList<ComponentType> Components => _components;
}
public enum ItemID
{
    wallet,
    medkit,
    bandage,
}

public enum ComponentType
{
    Wallet,

}