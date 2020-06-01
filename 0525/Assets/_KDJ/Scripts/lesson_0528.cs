using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lesson_0528 : MonoBehaviour
{
    Ray ray;
    RaycastHit[] hitInfo;

    public float rayDistance = 10.0f;

    LayerMask mask;

    Collider col;
    // Start is called before the first frame update
    void Start()
    {
        
        ray = new Ray();
        ray.origin = transform.position;
        ray.direction = transform.forward;

        
       
         hitInfo= Physics.RaycastAll(ray, rayDistance);
        
       

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            print("레이 발싸~~~~~~");
            Debug.DrawRay(ray.origin, ray.direction*rayDistance,Color.red,2.0f);

            //Raycast는 물리컴포넌트의 함수이기때문에 physice.Raycast로 함수를 호출해야 한다.
            if (Physics.Raycast(ray.origin, ray.direction, rayDistance))
            {
                print("발사한 오브젝트가 충돌됨");
            }

            for(int i=0; i<hitInfo.Length; i++)
            {
                if (Physics.Raycast(ray.origin, ray.direction,out hitInfo[i], rayDistance))
                {
                  //  print(hitInfo[i], col.gameObject.name);
                  //print(hitInfo[i],col.gameObject.name);
                }
            }
        

        }
    }
}
