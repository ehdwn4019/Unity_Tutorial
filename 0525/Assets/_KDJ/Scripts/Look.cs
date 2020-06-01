using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    //GameObject Player;
    //GameObject Enemy;
   
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        //enemy = GetComponent<GameObject>();
        //Player = GetComponent<GameObject>();
        //Enemy = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(enemy.transform);
       // Player.transform.LookAt(Enemy.transform);
    }
}
