using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class GreenEnemy : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        Name = "Green Enemy";
        Speed = 3;
        Force = 600;
        EnemyLocation = new Vector3(-2.25f, -7, -2);
    }

    protected override void Attack()
    {
        Ani.SetTrigger("attack_02");
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
