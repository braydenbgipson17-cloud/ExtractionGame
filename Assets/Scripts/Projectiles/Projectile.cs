using UnityEditor.Rendering;
using UnityEngine;

public class Projectile : MonoBehaviour
{
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
            Debug.Log("Hit: " + hitInfo.collider.name + " Hit Force: " + CalculateImpactForce() + "ft-lbs");
            Destroy(gameObject);
        }
        
    }

    float CalculateImpactForce()
    {
        return (_weight * _velocity * _velocity) / constant;
    }
}