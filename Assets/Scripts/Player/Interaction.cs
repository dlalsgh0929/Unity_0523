using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interaction : MonoBehaviour
{
    public float checkRate = 0.05f;
    private float lastCheckTime;
    public float maxCheckDistance;
    public LayerMask layerMask;

    public GameObject curInteractGameObject;
    private IIteractable curInteractable;

    public TextMeshProUGUI promtText;
    private Camera camera;



    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastCheckTime > checkRate)
        {
            lastCheckTime = Time.time;

            Ray ray = camera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, maxCheckDistance, layerMask))
            {
                if (hit.collider.gameObject != curInteractGameObject)
                {
                    curInteractGameObject = hit.collider.gameObject;
                    curInteractable = hit.collider.GetComponent<IIteractable>();
                    SetPromptText();


                }
            }
            else
            {
                curInteractGameObject = null;
                curInteractable = null;
                promtText.gameObject.SetActive(false);
            }
        }
    }

    private void SetPromptText()
    {
        promtText.gameObject.SetActive(true);
        promtText.text = curInteractable.GetInteractPrompt();
    }

    
}
