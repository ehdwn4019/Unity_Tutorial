using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CODI : MonoBehaviour
{
    int hairsIndex = 0;
    int clothesIndex = 0;
    int pantsIndex = 0;
      
    [SerializeField]
    GameObject[] hairs;
    [SerializeField]
    GameObject[] clothes;
    [SerializeField]
    GameObject[] pants;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i<hairs.Length; i++)
        {
            if(hairsIndex==i)
            {
                hairs[i].SetActive(true);
            }
            else
            {
                hairs[i].SetActive(false);
            }
        }

        for(int i=0; i<clothes.Length; i++)
        {
            if(clothesIndex==i)
            {
                clothes[i].SetActive(true);
            }
            else
            {
                clothes[i].SetActive(false);
            }
        }

        for(int i=0; i<pants.Length; i++)
        {
            if(pantsIndex==i)
            {
                pants[i].SetActive(true);
            }
            else
            {
                pants[i].SetActive(false);
            }
        }
    }

    public void LeftHair()
    {
        if(hairsIndex > 0)
        {
            hairsIndex--;
        }
    }

    public void RightHair()
    {
        
        if(hairsIndex< hairs.Length - 1)
        {
            hairsIndex++;
        }
        
    }

    public void LeftClothes()
    {
       
        if(clothesIndex>0)
        {
            clothesIndex--;
        }
    }

    public void RightClothe()
    {
        
        if(clothesIndex<clothes.Length-1)
        {
            clothesIndex++;
        }
    }

    public void LeftPants()
    {
        
        if(pantsIndex>0)
        {
            pantsIndex--;
        }
    }

    public void RightPants()
    {
        
        if(pantsIndex<pants.Length-1)
        {
            pantsIndex++;
        }
    }

    public void Save()
    {
        PlayerPrefs.SetInt("음", hairsIndex);
        PlayerPrefs.SetInt("어", clothesIndex);
        PlayerPrefs.SetInt("오", pantsIndex);
    }

    public void Load()
    {
        hairsIndex=PlayerPrefs.GetInt("음");
        clothesIndex = PlayerPrefs.GetInt("어");
        pantsIndex = PlayerPrefs.GetInt("오");
    }
}
