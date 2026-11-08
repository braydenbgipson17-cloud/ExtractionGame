using System;

using UnityEngine;


public class HealthSystem : MonoBehaviour, IDamageable // really want to c# this later face ie DamageReciver or some shit mono feeds to this c# class feed update clock to later deeper bleeding and other systems yuh yuh yuh.
{
    //base hp and stuff will come from data later when healing and other things come into play / health system will be deepened in some way later 

    [SerializeField] private float _maxHealth;
    [SerializeField] private float _currentHealth;

    public event Action OnDeath;

    void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void TakeDamage(float damage)
    {
        if (damage <= 0) { Debug.LogWarning($"Damage was {damage} on {this.gameObject.name} Bad config on projectile?"); return; } 

        _currentHealth -= damage; // dose clamp matter here? if we are -20 hp we are dead no coming back no healing. maybe hud other things will be out of whack let this bite me for once 

        if (isDead)
        {
            OnDeath?.Invoke();
        }
    }


    bool isDead => _currentHealth <= 0;
}