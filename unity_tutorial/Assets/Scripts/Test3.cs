﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{

    private BoxCollider col;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<BoxCollider>();
        
    }

    // Update is called once per frame
    void Update()
    {
        

        //if(Input.GetKeyDown(KeyCode.W))
        //{
        //    Debug.Log("col.bounds"+col.bounds);
        //    Debug.Log("col.bounds.extents"+col.bounds.extents);
        //    Debug.Log("col.bounds.extents" + col.bounds.extents.x);
        //    Debug.Log("col.size" + col.size);
        //    Debug.Log("col.center" + col.center);
        //}
        //if(Input.GetMouseButtonDown(0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hitInfo;
        //    if(col.Raycast(ray,out hitInfo,1000))
        //    {
        //        this.transform.position = hitInfo.point;
        //    }
        //}
        

    }

    private void OnTriggerEnter(Collider other)
    {

    }

    

    private void OnTriggerStay(Collider other)
    {
        other.transform.position += new Vector3(0, 0, 0.01f);
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.position = new Vector3(0, 2, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {

    }

    private void OnCollisionExit(Collision collision)
    {

    }

    private void OnCollisionStay(Collision collision)
    {

    }
    
}
