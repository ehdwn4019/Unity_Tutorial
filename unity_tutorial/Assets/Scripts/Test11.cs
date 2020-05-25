using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test11 : MonoBehaviour
{
    [SerializeField] private Slider slider;


    private bool isClick;

    private float dotTime = 1f;
    private float currentDotTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        currentDotTime = dotTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(isClick)
        {
            currentDotTime -= Time.deltaTime;

            if(currentDotTime<=0)
            {
                slider.value -= Time.deltaTime;

                if(currentDotTime<=-1f)
                {
                    currentDotTime = dotTime;
                }
            }

            
        }
       
    }

    public void Button()
    {
        //slider.value -= 1;\
        isClick = true;
    }
}
