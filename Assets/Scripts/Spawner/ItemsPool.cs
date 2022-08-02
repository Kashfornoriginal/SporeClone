using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ItemsPool : MonoBehaviour
{
    System.Random random = new System.Random();
    
    [SerializeField] private Transform _objectContainer;

    [SerializeField] private int _amountOfObjects;

    private List<GameObject> _objectsPool = new List<GameObject>();

    protected void Initialize(ItemsData[] objectPrefab)
    {
        for (int i = 0; i < _amountOfObjects; i++)
        {
            GameObject spawnedObject = Instantiate(objectPrefab[random.Next(0,objectPrefab.Length)].Prefab, _objectContainer.transform);
            spawnedObject.SetActive(false);
            
            _objectsPool.Add(spawnedObject);
        }
    }

    protected bool TryGetObjectFromPool(out GameObject result)
    {
        result = _objectsPool.FirstOrDefault(p => p.activeSelf == false);
        return result != null;
    }
}
