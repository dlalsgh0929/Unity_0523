using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if(!collision.gameObject.TryGetComponent<Rigidbody>(out Rigidbody rb))
        {
            return;
        }
        
        rb.AddForce(Vector2.up * 400, ForceMode.Impulse);
        
        
    }
}
