using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCondition : MonoBehaviour
{
    public UICondition uiCondition;

    Condition health { get { return uiCondition.health; } }

    

    // Update is called once per frame
    void Update()
    {
        if (health.curValue == 0)
        {
            Die();
        }
    }

    public void Heal(float amout)
    {
        health.Add(amout);
    }

    public void Die()
    {
        Debug.Log("»ç¸Á");
    }

    public void TakePhysicalDamage(int damage)
    {
        health.Subtract(damage);       
    }
}
