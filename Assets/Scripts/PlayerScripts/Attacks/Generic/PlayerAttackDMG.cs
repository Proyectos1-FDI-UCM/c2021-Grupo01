﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackDMG : MonoBehaviour
{
    [SerializeField]
    private int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            collision.gameObject.GetComponent<EnemyDamage>().TakeDamage(damage);
                
        }

        Debug.Log("hola buenas tardes");
    }
}
