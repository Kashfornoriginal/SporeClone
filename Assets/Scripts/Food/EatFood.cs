using UnityEngine;

public class EatFood : MonoBehaviour
{
    private void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.GetComponent<Player>() == true)
        {
            gameObject.SetActive(false);
        }
    }
}
