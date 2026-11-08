using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] HealthSystem _healthSystem;
    private void Start()
    {
        _healthSystem.OnDeath += KillObject;
    }
    private void OnDestroy()
    {
        _healthSystem.OnDeath -= KillObject;
    }
    void KillObject()
    {
        Destroy(gameObject);
    }
}
