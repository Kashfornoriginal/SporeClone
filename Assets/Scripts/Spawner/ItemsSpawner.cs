using UnityEngine;

public class ItemsSpawner : ItemsPool
{
    [SerializeField] private ItemsData[] _foodPrefabs;

    [SerializeField] private RandomPositionMover _randomPositionMover;

    private void Start()
    {
        Initialize(_foodPrefabs);
    }

    private void Update()
    {
        if(TryGetObjectFromPool(out GameObject obj))
        {
            SetObject(obj);
        }
    }

    private void SetObject(GameObject obj)
    {
        obj.SetActive(true);
        _randomPositionMover.MoveObjectToRandomPosition(obj);
    }
}
