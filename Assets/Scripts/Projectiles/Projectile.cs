using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float _damage; // will come from data later also i want energy to play a role into this as well as roun type later flat for now 
    private Vector3 _moveDir;
    [SerializeField] private float _velocity;
    [SerializeField] private float _weight;
    private float constant = 450436f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 10);// temp times to destroy one day bullet drop will make impact happen all the time
    }

    // Update is called once per frame
    void Update()
    {
        MoveProjectile();
    }

    public void SetMoveDirection(Vector3 moveDir)
    {
        _moveDir = moveDir;
    }

    public void MoveProjectile()
    {
        DetectCollisions();
        transform.position += _moveDir * _velocity * Time.deltaTime;
    }

    void DetectCollisions()
    {
        
        if (Physics.Raycast(transform.position, _moveDir, out RaycastHit hitInfo, _velocity * Time.deltaTime))
        {
            if (hitInfo.collider.TryGetComponent<IDamageable>(out var target)) { target.TakeDamage(_damage); }
            Debug.Log("Hit: " + hitInfo.collider.name + " Hit Force: " + CalculateImpactForce() + "ft-lbs");
            Destroy(gameObject); // place holder when penitration and other things come we wont always want to destroy the gameobject
            
        }
       
    }

    float CalculateImpactForce()
    {
        return (_weight * _velocity * _velocity) / constant;
    }
}