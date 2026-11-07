using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Vector3 _moveDir;
    [SerializeField] private float _velocity;

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
        transform.position += _moveDir * _velocity * Time.deltaTime;
    }
    
}
