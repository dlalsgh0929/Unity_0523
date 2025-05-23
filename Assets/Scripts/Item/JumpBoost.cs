using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : MonoBehaviour
{
    public float oriJumpPower; // �÷��̾��� ���� ������


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
        Debug.Log("������ȭ");
        yield return new WaitForSeconds(3);
        CharacterManager.Instance.Player.controller.jumpPower = oriJumpPower;
        Debug.Log("���� ��ȭ ����");
    }
}
