using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;      //  default enemy 

    public GameObject deathEffect; 

    public void TakeDamage(int damage)      // if enemy has 0 health he will be destroyed

    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }

    }

    public void Die() 
    {
        
        Destroy(gameObject);

    }
}
