using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //변수 작성할떄 소문자로 이름 짓기 
    //함수,클래스,프라퍼티는 대문자로 이름 짓기
    //int number = 0;

    //Transform => 컴포넌트 (게임만드는데 가장 중요한 컴포넌트)
    //매트릭스 4 * 4
    //트랜스폼 컴포넌트는 자주 사용하는 거라서
    //GetComponent<Transform>(); 가져 올 필요가 없다 
    //게임오브젝트 컴포넌트 또한 자주 사용하는 거라서
    //GetComponent<GameObject>(); 가져 올 필요가 없다 
    //Transform tr;
    //GameObject go;
    //짐벌락-> 두개축이 겹쳐서 오류나는거 

    float speed = 5.0f;




    // Start is called before the first frame update
    void Start()
    {
        //tr = GetComponent<Transform>();
        //go = GetComponent<GameObject>(); 

        print(gameObject.name);
        print(transform.name);

        //transform.position = new Vector3(0, 5, 0);
    }

    // Update is called once per frame
    void Update()
    {

        //transform.position.x
        //Pos=Pos0+vt
        //Pos+=vt;
        //Time.deltaTime
        //transform.position += Vector3.right * speed * Time.deltaTime;
        //transform.Translate(Vector3.forward*speed*Time.deltaTime);

        // if(Input.GetKey(KeyCode.UpArrow))
        // {
        //     transform.Translate(Vector3.forward * speed * Time.deltaTime);
        // }
        // if (Input.GetKey(KeyCode.DownArrow))
        // {
        //     transform.Translate(Vector3.back * speed * Time.deltaTime);
        // }
        // if (Input.GetKey(KeyCode.LeftArrow))
        // {
        //     transform.Translate(Vector3.left* speed*Time.deltaTime);
        // }
        // if (Input.GetKey(KeyCode.RightArrow))
        // {
        //     transform.Translate(Vector3.right * speed* Time.deltaTime);
        // }

       //h = speed * Time.deltaTime;
       //v = speed * Time.deltaTime;

        //horizontal , vertical 쓰는 이유 -> 크로스 플랫폼 지원하려고(조이스틱에는 키보드 방향키 X)
         float h = Input.GetAxis("Horizontal")*speed* Time.deltaTime;
         float v = Input.GetAxis("Vertical") * speed * Time.deltaTime;


        transform.position += Vector3.right * h + Vector3.forward * v;

        //이동거리
        h = h * speed * Time.deltaTime;
        v = v * speed * Time.deltaTime;

        //실제이동
        transform.Translate(Vector3.right * h);
        transform.Translate(Vector3.forward*v);

        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * speed * mouseX);
        

    }
}
