using UnityEngine;

public class EnemyAIMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private Transform _playerPos; // temp want to find a more engaging way to have ai find this out 

    bool isDead = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead)
        {
            MoveTowardsPlayer();
        }
    }

    void MoveTowardsPlayer()
    {
        Vector3 moveDirection = _playerPos.position - transform.position;
        moveDirection.Normalize();
        transform.position += moveDirection * _moveSpeed * Time.deltaTime;
    }

    public void SetDeathState(bool isDie) //temp loot testing
    {
        isDead = isDie;
    }
}
