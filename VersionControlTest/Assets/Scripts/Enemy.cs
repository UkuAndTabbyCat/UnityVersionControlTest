using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    private PlayerController playerController;
    public string Name { get; set; }

    public float Speed { get; set; }

    public float Force { get; set; }

    public Vector3 EnemyLocation { get; set; }

    public Animator Ani { get; set; }

    public Rigidbody2D Rigi { get; set; }

    public void Awake()
    {
        Ani = GetComponent<Animator>();
        Rigi = GetComponent<Rigidbody2D>();
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    public void Update()
    {
        if (playerController.Instance.IsMoving)
        {
            Move();
        }
        else
        {
            StopMove();
        }

        if (playerController.Instance.IsJumping)
        {
            Jump();
        }

        if (playerController.Instance.IsAttacking)
        {
            Attack();
        }
    }
    protected abstract void StopMove();
    protected abstract void Move();
    protected abstract void Jump();
    protected abstract void Attack();
    protected abstract void Talk();
}
