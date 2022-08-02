using UnityEngine;

[CreateAssetMenu(fileName = "Food", menuName = "ScriptableObjects/Item/Food")]
public class Food : ItemsData
{
    [SerializeField] private int _recoveryValue;

    public int RecoveryValue => _recoveryValue;
}
