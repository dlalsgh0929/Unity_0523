using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPotion : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        CharacterManager.Instance.Player.condition.Heal(20);
        Debug.Log("20 È¸º¹");
    }

}
