using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;

    private PlayerInputActions _inputActions;

    public event Action<Vector2> OnPlayerMove;
    public event Action<Vector2> OnPlayerLook;
    public event Action OnPlayerFire;
    public event Action OnPlayerInteract;
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
        _inputActions.Player.Look.performed += PlayerLook;
        _inputActions.Player.Look.canceled += PlayerLook;
        _inputActions.Player.Fire.performed += PlayerFire;
        _inputActions.Player.Interact.performed += PlayerInteract;
    }

    private void OnDisable()
    {
        _inputActions.Player.Disable();
        _inputActions.Player.Move.performed -= PlayerMove;
        _inputActions.Player.Move.canceled -= PlayerMove;
        _inputActions.Player.Look.performed -= PlayerLook;
        _inputActions.Player.Look.canceled -= PlayerLook;
        _inputActions.Player.Fire.performed -= PlayerFire;
        _inputActions.Player.Interact.performed -= PlayerInteract;
    }


    public void PlayerMove(InputAction.CallbackContext context)
    {
        OnPlayerMove?.Invoke(context.ReadValue<Vector2>());
    }

    public void PlayerLook(InputAction.CallbackContext context)
    {
        OnPlayerLook?.Invoke(context.ReadValue<Vector2>());
    }

    public void PlayerFire(InputAction.CallbackContext context)
    {
        OnPlayerFire?.Invoke();
    }

    public void PlayerInteract(InputAction.CallbackContext context)
    {
        OnPlayerInteract?.Invoke();
    }
   
}
