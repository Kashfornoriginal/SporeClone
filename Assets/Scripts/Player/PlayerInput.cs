using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private PlayerMover _playerMover;
    
    [SerializeField] private FixedJoystick _joystick;

    private void FixedUpdate()
    {
        _playerMover.Move(_joystick);
    }

    private void Update()
    {
        /*
        Ray _touchPosition = _camera.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(_touchPosition, out RaycastHit raycastHit))
            {
                _playerMover.Move(raycastHit.point);
            }
        }
        */
    }
}
