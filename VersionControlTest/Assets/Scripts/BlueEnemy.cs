using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueEnemy : Enemy
{

    // Start is called before the first frame update
    void Start()
    {
        Name = "Blue Enemy";
        Speed = 1;
        Force = 500;
        EnemyLocation = new Vector3(-7.5f, -7, -2);
    }

    protected override void Attack()
    {
        Ani.SetTrigger("attack_01");
    }

    protected override void Jump()
    {
        Rigi.AddForce(Vector2.up * Force, ForceMode2D.Impulse);
    }

    protected override void Move()
    {
        Ani.SetBool("walk_b", true);
    }

    protected override void StopMove()
    {
        Ani.SetBool("walk_b", false);
    }
    protected override void Talk()
    {

    }
}
