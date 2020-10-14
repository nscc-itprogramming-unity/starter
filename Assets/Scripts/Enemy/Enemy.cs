using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    public GameObject deathEffect;

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    private void Update()
    {
        //TODO remove hard-coded value
        if (gameObject.transform.position.x <= -5)
        {
            Destroy(gameObject);
        }
    }

    void Die ()
    {
        Destroy(gameObject);
    }


}