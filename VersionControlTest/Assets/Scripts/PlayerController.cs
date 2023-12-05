using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float inputHorizontal;
    [SerializeField] private float speed;
    [SerializeField] private float force;

    public PlayerController Instance { get; private set; }
    public bool IsMoving { get; private set; }
    public bool IsJumping { get; private set; }
    public bool IsAttacking { get; private set; }


    private Rigidbody2D playerRb2D;
    private Animator playerAni;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        playerRb2D = GetComponent<Rigidbody2D>();
        playerAni = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        inputHorizontal = Input.GetAxis("Horizontal");
        Move();
        playerAni.SetFloat("speed_f", Mathf.Abs(inputHorizontal));

        if (inputHorizontal == 0)
        {
            IsMoving = false;
        }
        else
        {
            IsMoving = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            IsJumping = true;
        }
        else
        {
            IsJumping = false;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Attack();
            IsAttacking = true;
        }
        else
        {
            IsAttacking = false;
        }
    }

    void Move()
    {
        if (inputHorizontal < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.Translate(Vector2.left * Time.deltaTime * inputHorizontal * speed);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.Translate(Vector2.right * Time.deltaTime * inputHorizontal * speed);
        }
    }

    void Jump()
    {
        playerRb2D.AddForce(Vector2.up * force, ForceMode2D.Impulse);
    }

    void Attack()
    {
        playerAni.SetTrigger("attack_03");
    }
}
