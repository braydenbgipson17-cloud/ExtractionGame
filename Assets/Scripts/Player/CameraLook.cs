using UnityEngine;

public class CameraLook : MonoBehaviour
{
    [SerializeField] private float _sensitivity = 0.1f;

    [SerializeField] private Transform _playerBody;

    private float _pitchDelta;
    private Vector2 _mouseDirection;

   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InputManager.Instance.OnPlayerLook += SetMouseDirection;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Look();
       
    }

    void SetMouseDirection(Vector2 mouseDirection)
    {
        _mouseDirection = mouseDirection;
    }

    void Look()
    {
        float xRotation = _mouseDirection.x * _sensitivity;
        float yRotation = _mouseDirection.y * _sensitivity;

        _playerBody.Rotate(0, xRotation, 0);

        _pitchDelta -= yRotation;
        _pitchDelta = Mathf.Clamp(_pitchDelta, -90, 90);
       transform.localRotation = Quaternion.Euler(_pitchDelta, 0, 0);  
    }


   
}
