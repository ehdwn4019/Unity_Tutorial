using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{

    CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        controller.Move(Vector3.forward * Time.deltaTime * 3);
        if(controller.isGrounded)
        {
            transform.position = Vector3.up;
        }
    }
}
