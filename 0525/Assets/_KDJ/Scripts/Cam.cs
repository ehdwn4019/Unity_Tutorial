using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    [SerializeField]
    Camera cam;

    [SerializeField]
    Transform cube;

    [SerializeField]
    float speed;
    [SerializeField]
    float angle;

    // Start is called before the first frame update
    void Start()
    {
       // speed = 3.0f;
       // angle =1.0f;
        cam = GetComponent<Camera>();
        cube = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.DownArrow))
        {
            cam.fieldOfView++;
        }
        else if(Input.GetKey(KeyCode.UpArrow))
        {
            cam.fieldOfView--;
        }


        if(Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.RotateAround(cube.transform.position,Vector3.up* speed * Time.deltaTime, angle);

        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.RotateAround(cube.transform.position, Vector3.down * speed * Time.deltaTime, angle);
        }

        if(Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

    }
}
