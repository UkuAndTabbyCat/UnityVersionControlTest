using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class BossEnemy : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        Name = "Boss Enemy";
        Speed = 3;
        Force = 700;
        EnemyLocation = new Vector3(7.7f, -7, -2);
    }

    protected override void Attack()
    {
        Ani.SetTrigger("attack_boss");
    }

    protected override void Jump()
    {
        Rigi.AddForce(Vector2.up * Force, ForceMode2D.Impulse);
    }

    protected override void Move()
    {
        Ani.SetBool("run_b", true);
    }

    protected override void StopMove()
    {
        Ani.SetBool("run_b", false);
    }
    protected override void Talk()
    {

    }
}
