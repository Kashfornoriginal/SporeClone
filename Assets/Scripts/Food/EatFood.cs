using UnityEngine;

public class EatFood : MonoBehaviour
{
    private void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.GetComponent<Player>() == true)
        {
            Destroy(gameObject);
        }
    }
}
