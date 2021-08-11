using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;    //speed of the bullet
    public int damage = 50;      // default damage by the bullet
    public Rigidbody2D rb;       // reference to the rigidoby2D of the Bullet prefab for physics

    void Start()
    {
        rb.velocity = transform.right * speed;

    }

    void OnTriggerEnter2D(Collider2D hitInfo)    // if enemy gets hit by the bullet prefab in his 2D collider he will take damage
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);                  // bullet disappears when it will hit an Game Object
    }


}