using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lessonCam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            transform.Translate(Input.GetAxisRaw("Mouse X") / 10.0f, 0.0f,Input.GetAxisRaw("Mouse Y")/10.0f,0.0f);
        }

        //if(Input.GetMouseButton(1))
        //{
        //    transform.Translate(Input.GetAxisRaw("Mouse Scrollwhell"))
        //}
    }
}
