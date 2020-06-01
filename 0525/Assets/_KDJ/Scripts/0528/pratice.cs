using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pratice : MonoBehaviour
{
    Ray ray;
    Ray ray2;
    RaycastHit hitInfo;
    RaycastHit hitInfot2;

    [SerializeField]
    float duration;
    [SerializeField]
    float angle;

    // Start is called before the first frame update
    void Start()
    {
        ray = new Ray();
        ray2 = new Ray();
    }

    // Update is called once per frame
    void Update()
    {
        ray.origin = transform.position;
        ray2.origin = transform.position;
        ray.direction = transform.forward + Vector3.right;
        ray2.direction = transform.forward + Vector3.left;
        
        this.transform.Translate(Vector3.forward*Time.deltaTime*3.0f);
        Debug.DrawRay(this.transform.position, ray.direction * duration, Color.red);
        Debug.DrawRay(this.transform.position, ray2.direction * duration, Color.red);

        if(Physics.Raycast(ray.origin, ray.direction, duration))
        {
            this.transform.Rotate(Vector3.up * -angle);
        }
        if(Physics.Raycast(ray2.origin,ray2.direction, duration))
        {
            this.transform.Rotate(Vector3.up * angle);
        }
        Debug.Log("맞음");

        
        
    }

   //private void OnCollisionStay(Collision collision)
   //{
   //    if(collision.transform)
   //    {
   //        this.transform.Rotate(Vector3.forward, angle);
   //    }
   //}
}
