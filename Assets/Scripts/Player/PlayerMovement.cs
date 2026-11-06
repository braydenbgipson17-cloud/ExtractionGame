using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float _moveSpeed;

    Vector2 _moveDirection;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InputManager.Instance.OnPlayerMove += SetMoveDirection;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }



    private void SetMoveDirection(Vector2 moveDirection)
    {
        _moveDirection = moveDirection;
    }

    private void Move()
    {
        Vector3 moveDir = transform.forward * _moveDirection.y + transform.right * _moveDirection.x;

        moveDir.Normalize();

        transform.position += moveDir * _moveSpeed * Time.deltaTime;
    }
}
