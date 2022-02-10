using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class teenBoy_animation_controls : MonoBehaviour
{
    [SerializeField]
    Animator anim_controller;

    [SerializeField]
    Text textField;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAnim() 
    {
        string animationName = textField.text.ToLower();

        switch (animationName)
        {
            case "run":
                anim_controller.SetBool("isRunning", true);
                break;
            case "walk":
                anim_controller.SetBool("isWalking", true);
                break;
            case "sneeze":
                anim_controller.SetBool("isSneezing", true);
                break;
            case "default":
                Debug.Log("Teen toon shrugs. (Unkown command)");
                break;
        }
        
    }
}
