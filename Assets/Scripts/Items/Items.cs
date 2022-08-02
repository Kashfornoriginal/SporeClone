using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "ScriptableObjects/Item")]
public class Items : ScriptableObject
{
    [SerializeField] private string _id;
    [SerializeField] private string _name;
    [SerializeField] private ItemType _type;
    [SerializeField] private Sprite _icon;
    [SerializeField] private GameObject _prefab;

    public string ID => _id;
    public string Name => _name;
    public ItemType Type => _type;
    public Sprite Icon => _icon;
    public GameObject Prefab => _prefab;
}

public enum ItemType
{
    Food
}

