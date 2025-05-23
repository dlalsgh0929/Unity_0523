using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDamage : MonoBehaviour
{
    
    public Transform playerPosition;
    private Vector3 highestHeight;
    private Vector3 curHeight;
    private bool isFalling = false;


    // Start is called before the first frame update
    void Start()
    {
        playerPosition= CharacterManager.Instance.Player.GetComponent<Transform>();
        highestHeight = playerPosition.position;
    }

    // Update is called once per frame
    void Update()
    {
        curHeight = playerPosition.position;

        if (!CharacterManager.Instance.Player.controller.IsGrounded())
        {
            if (!isFalling)
            {
                highestHeight = curHeight;
                isFalling = true;
            }
            else if(curHeight.y >  highestHeight.y)
            {
                highestHeight = curHeight;
            }
        }

        if(isFalling && CharacterManager.Instance.Player.controller.IsGrounded())
        {
            Fall();
        }
    }

    public void Fall()
    {
        if(highestHeight.y - curHeight.y > 7f)
        {
            CharacterManager.Instance.Player.condition.TakePhysicalDamage(10);
            
        }
        
        isFalling=false;
    }
}
