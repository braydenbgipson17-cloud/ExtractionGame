using UnityEngine;

public class AIDeathHandler : MonoBehaviour
{
    [SerializeField] HealthSystem _healthSystem;
    [SerializeField] LootableContainer _lootableContainer;
    [SerializeField] EnemyAIMovement _enemyAIMovement;
    private void Start()
    {
        _healthSystem.OnDeath += AllowLooting;
    }
    private void OnDestroy()
    {
        _healthSystem.OnDeath -= AllowLooting;
    }
    void AllowLooting()
    {
        _lootableContainer.enabled = true;
        _enemyAIMovement.SetDeathState(true);
    }
}
