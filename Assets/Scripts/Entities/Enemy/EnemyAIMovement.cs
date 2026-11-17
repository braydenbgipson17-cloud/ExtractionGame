using UnityEngine;

public class EnemyAIMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
     private Transform _playerPos; // temp want to find a more engaging way to have ai find this out 

    bool isDead = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _playerPos = FindAnyObjectByType<Player>().transform;
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
        if(_playerPos == null)
        {
            GetPlayerPos();
        }
        Vector3 moveDirection = _playerPos.position - transform.position; // will need to "inject" this on scene load for now
        moveDirection.Normalize();
        transform.position += moveDirection * _moveSpeed * Time.deltaTime;
    }

    public void SetDeathState(bool isDie) //temp loot testing
    {
        isDead = isDie;
    }

    void GetPlayerPos()
    {
        _playerPos = FindAnyObjectByType<Player>().transform;
    }
}
