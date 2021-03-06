﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class inherited by Player and Enemy that contains common functions shared by both, like taking damage and dieing.


public class LivingEntity : MonoBehaviour, IDamageable
{
    public float startingHealth;
    public float health { get; protected set; }
    protected bool dead;

    public event System.Action OnDeath;


    protected virtual void Start()
    {
        health = startingHealth;
    }

    public virtual void TakeHit(float damage, Vector3 hitPoint, Vector3 hitDirection)
    {
        //TODO do something with hit variable
        TakeDamage(damage);
    
    }

    public virtual void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0 && !dead)
        {
            Die();
        }
    }

    [ContextMenu("Self Destruct")]
    public virtual void Die()
    {
        dead = true;
        if (OnDeath != null)
        {
            OnDeath();
        }

        Destroy(this.gameObject);
    }
}
