﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class Dialogue
{
    [TextArea]
    public string dialogue;
    public Sprite cg;
}

public class Test13 : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite_StandingCG;
    [SerializeField] private SpriteRenderer sprite_DialoogueBox;
    [SerializeField] private Text txt_Dialogue;

    private bool isDialogue = false;

    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;

    public void ShowDialogue()
    {
        //sprite_DialoogueBox.gameObject.SetActive(true);
        //sprite_StandingCG.gameObject.SetActive(true);
        //txt_Dialogue.gameObject.SetActive(true);

        OnOff(true);
        count = 0;
        //isDialogue = true;
        NextDialogue();

    }

    private void OnOff(bool _flag)
    {
        sprite_DialoogueBox.gameObject.SetActive(_flag);
        sprite_StandingCG.gameObject.SetActive(_flag);
        txt_Dialogue.gameObject.SetActive(_flag);
        isDialogue = _flag;
    }

    private void NextDialogue()
    {
        txt_Dialogue.text = dialogue[count].dialogue;
        sprite_StandingCG.sprite = dialogue[count].cg;
        count++;
    }

   //private void HideDialogue()
   //{
   //    sprite_DialoogueBox.gameObject.SetActive(false);
   //    sprite_StandingCG.gameObject.SetActive(false);
   //    txt_Dialogue.gameObject.SetActive(false);
   //    isDialogue = true;
   //}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(isDialogue)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                if(count<dialogue.Length)
                {
                    NextDialogue();
                }
                else
                {
                    OnOff(false);
                }
            }
        }
    }
}
