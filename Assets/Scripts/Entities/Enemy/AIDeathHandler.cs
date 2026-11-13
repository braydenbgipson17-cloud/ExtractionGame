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
      _lootableContainer.SetLootable(true);
        _enemyAIMovement.SetDeathState(true); //temp states later just to make movemetn stop to loot 
    }
}
