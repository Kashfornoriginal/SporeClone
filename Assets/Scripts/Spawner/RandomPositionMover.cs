using UnityEngine;

public class RandomPositionMover : MonoBehaviour
{
    System.Random random = new System.Random();
    
    [SerializeField] private int _minX;
    [SerializeField] private int _maxX;
    [SerializeField] private int _minZ;
    [SerializeField] private int _maxZ;

    [SerializeField] private float _height;
    
    public void MoveObjectToRandomPosition(GameObject obj)
    {
        obj.transform.position = RandomPositionGenerator();
    }

    private Vector3 RandomPositionGenerator()
    {
        Vector3 position = new Vector3(random.Next(_minX * 100, _maxX * 100) / 100f, _height, random.Next(_minZ * 100, _maxZ * 100) / 100f);
        return position;
    }
}
