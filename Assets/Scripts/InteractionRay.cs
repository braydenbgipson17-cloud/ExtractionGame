using UnityEngine;

public class InteractionRay : MonoBehaviour
{

    [SerializeField] private float _interactionRange;

    [SerializeField] private EntityIdentity _entityID;

    IInteractable _currentInteractable; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InputManager.Instance.OnPlayerInteract += Interact;
    }

    private void OnDestroy()
    {
        InputManager.Instance.OnPlayerInteract -= Interact;
    }
    // Update is called once per frame
    void Update()
    {
        InteractionRaycast();
    }


    void InteractionRaycast() 
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo, _interactionRange))
        {
            if (hitInfo.collider.TryGetComponent<IInteractable>(out IInteractable interactable))
            {
                _currentInteractable = interactable;
               
            }
            else { _currentInteractable = null; }
        }
        else { _currentInteractable = null;}
    }

    void Interact()
    {
        if (_currentInteractable != null)
        {
            _currentInteractable.InteractAction(_entityID);
        }
    }
}
