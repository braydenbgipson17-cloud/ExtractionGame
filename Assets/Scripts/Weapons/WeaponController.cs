using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] private Transform _firePoint;
    [SerializeField] private GameObject _projectilePrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InputManager.Instance.OnPlayerFire += Shoot;
    }

    private void OnDestroy()
    {
        InputManager.Instance.OnPlayerFire -= Shoot;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot()
    {
        GameObject projectileObject = Instantiate(_projectilePrefab, _firePoint.position, _firePoint.rotation);
        if(!projectileObject.TryGetComponent<Projectile>(out Projectile projectile))
        {
            Debug.LogWarning("Projectile component not attached to projectile");
            return;
        }
        projectile.SetMoveDirection(_firePoint.forward);
    }

    
}
