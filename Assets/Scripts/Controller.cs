using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public GameObject avatar;
    public Text actionText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Animate()
    {
        Debug.Log(actionText.text);
        if (actionText.text == "sneeze")
        {
            avatar.GetComponent<Animator>().Play("TTB_sneeze");
        }
        else if (actionText.text == "walk")
        {
            avatar.GetComponent<Animator>().Play("TTB_walk2");
        }
        else if (actionText.text == "run")
        {
            avatar.GetComponent<Animator>().Play("TTB_run");
        }
        else
            return;
    }
}
