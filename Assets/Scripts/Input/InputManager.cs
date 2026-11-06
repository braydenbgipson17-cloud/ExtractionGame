using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;

    private PlayerInputActions _inputActions;

    public event Action<Vector2> OnPlayerMove;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        _inputActions = new PlayerInputActions();

        

    }

    private void OnEnable()
    {
        _inputActions.Player.Enable();
        _inputActions.Player.Move.performed += PlayerMove;
        _inputActions.Player.Move.canceled += PlayerMove;
    }

    private void OnDisable()
    {
        _inputActions.Player.Disable();
        _inputActions.Player.Move.performed -= PlayerMove;
        _inputActions.Player.Move.canceled -= PlayerMove;
    }


    public void PlayerMove(InputAction.CallbackContext context)
    {
        OnPlayerMove?.Invoke(context.ReadValue<Vector2>());
    }

   
}
