using UnityEngine;

public class RaidButton : MonoBehaviour, IInteractable
{
    [SerializeField] private SceneLoader _sceneLoader;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InteractAction(IInteractor interactor)
    {
        _sceneLoader.LoadRaidScene();
    }
}
