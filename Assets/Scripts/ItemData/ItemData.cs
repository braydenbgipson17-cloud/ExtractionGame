using UnityEngine;

[CreateAssetMenu(fileName ="Item", menuName = "ItemData")]
public class ItemData : ScriptableObject
{
    //maybe unique id (still a bit unsure what an id gives me i know lookups but from here or maybe a lootenetry object
    [SerializeField] private string _name;
    [SerializeField] private string _description;
    //type 
    //weight
    //catigory?? 
    //gameobject prefab

    //[SerializeField] private Image icon;


    public string Name => _name;
    public string Description => _description;
}
