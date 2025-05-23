using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    private static CharacterManager instance;

    public static CharacterManager Instance
    {
        get
        {
            // instance가 비워져있으면
            if(instance == null)
            {
                // CharacterManager 오브젝트를 만들고 컴포넌트 추가
                instance = new GameObject("CharacterManager").AddComponent<CharacterManager>(); 
            }
            return instance;
        }
    }

    public Player player;
    public Player Player
    {
        get { return player; }
        set {  player = value; }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(instance == this)
        {
            Destroy(gameObject);
        }
    }
}
