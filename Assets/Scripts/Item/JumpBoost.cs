using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : MonoBehaviour
{
    public float oriJumpPower; // 플레이어의 원래 점프력


    // Start is called before the first frame update
    void Start()
    {
        oriJumpPower = CharacterManager.Instance.Player.controller.jumpPower;
    }

    private void OnTriggerEnter(Collider other)
    {          
           StartCoroutine(JumpBoosting());       
    }

    private IEnumerator JumpBoosting()
    {
        CharacterManager.Instance.Player.controller.jumpPower *= 1.5f;
        Debug.Log("점프강화");
        yield return new WaitForSeconds(3);
        CharacterManager.Instance.Player.controller.jumpPower = oriJumpPower;
        Debug.Log("점프 강화 종료");
    }
}
