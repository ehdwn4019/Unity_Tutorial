using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    private GameObject go_camera;
   //Vector3 rotation;
   //
   //void Start()
   //{
   //    rotation = this.transform.eulerAngles;
   //}

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKey(KeyCode.W))
        //{
        //    //rotation=rotation+ new Vector3(90, 0, 0) * Time.deltaTime;
        //    //this.transform.position = this.transform.position + new Vector3(0, 0, 1)*Time.deltaTime;
        //    //this.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);
        //    //this.transform.eulerAngles = rotation;
        //    // Debug.Log(transform.eulerAngles);
        //    //this.transform.Rotate(new Vector3(90, 0, 0) * Time.deltaTime);
        //    //rotation = rotation + new Vector3(90, 0, 0) * Time.deltaTime;
        //    //this.transform.rotation = Quaternion.Euler(rotation);
        //    //this.transform.localScale = this.transform.localScale + new Vector3(2, 2, 2) * Time.deltaTime;
        //    //moveSpeed*this.transform.forward * Time.deltaTime;
        //   // this.transform.LookAt(go_camera.transform.position);
        //}
        transform.RotateAround(go_camera.transform.position, Vector3.up, 100 * Time.deltaTime);
    }
}
