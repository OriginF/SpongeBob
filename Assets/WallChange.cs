using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0);
    }

    public void PointerEnter()
    {
        this.GetComponent<MeshRenderer>().material.color = Color.blue;
        transform.Translate(1,1,1);
    }
}
