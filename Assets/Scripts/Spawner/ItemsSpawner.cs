using UnityEngine;

public class ItemsSpawner : ItemsPool
{
    [SerializeField] private ItemsData[] _foodPrefabs;

    [SerializeField] private RandomPositionMover _randomPositionMover;

    [SerializeField] private float _timeBetweenFoodSpawn;

    private float _currentTimeBetweenFood;

    private void Start()
    {
        Initialize(_foodPrefabs);
    }

    private void FixedUpdate()
    {
        _currentTimeBetweenFood += Time.fixedDeltaTime;

        if (_currentTimeBetweenFood >= _timeBetweenFoodSpawn)
        {
            if(TryGetObjectFromPool(out GameObject obj))
            {
                SetObject(obj);
            }

            _currentTimeBetweenFood = 0;
        }
    }

    private void SetObject(GameObject obj)
    {
        obj.SetActive(true);
        _randomPositionMover.MoveObjectToRandomPosition(obj);
    }
}
