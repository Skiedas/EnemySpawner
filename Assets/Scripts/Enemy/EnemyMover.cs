using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private int _moveDirection;

    private void Start()
    {
        _moveDirection = SetMoveDirection();
        transform.localScale = new Vector3(-_moveDirection, 1, 1);
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(_moveDirection * _moveSpeed * Time.deltaTime, 0, 0);
    }

    private int SetMoveDirection()
    {
        int moveDirection = Random.Range(0, 2);

        if (moveDirection == 0)
            moveDirection = -1;

        return moveDirection;
    }
}
