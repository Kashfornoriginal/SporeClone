using UnityEngine;

public class PlayerMover : MonoBehaviour, IMovement
{
    [SerializeField] private float _speed;

    [SerializeField] private Rigidbody _rigidbody;
    
    public void Move(Joystick joystick)
    {
        _rigidbody.velocity = new Vector3(joystick.Horizontal * _speed, _rigidbody.velocity.y, joystick.Vertical * _speed);
        if (joystick.Horizontal != 0 || joystick.Vertical != 0)
        {   
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
        }
    }
}
