using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update

    private Camera mainCamera;
    private GameObject gameObject;

    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0);
        if (mainCamera.transform.up.x > 1)
        {
            
        }
        else if(mainCamera.transform.up.x < 1)
        {
            
        }
    }

    public void PointerEnter()
    {
        this.transform.Translate(1,1,1);
        Debug.Log("haha");
    }

    public void PointerClick()
    {
        this.transform.Translate(1,1,1);
        Debug.Log("ok");
    }
}
