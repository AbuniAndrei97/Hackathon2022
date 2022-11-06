using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DiceScript : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public Button button;
    public Sprite Sprite1, Sprite2, Sprite3, Sprite4, Sprite5, Sprite6;
    public void Click()
    {
        
            int randomNumber = UnityEngine.Random.Range(1, 6);
            anim.SetInteger("Dice",randomNumber);

        
    }


}
