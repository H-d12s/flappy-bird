using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bo : MonoBehaviour
{
    private Animator anim;
    private string walkanim = "wingsflap";

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        if (anim == null)
        {
            Debug.LogError("Animator component not found on this GameObject!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        animplay();
    }

    public void animplay()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Spacebar pressed");
            anim.SetBool(walkanim, true);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Spacebar released");
            anim.SetBool(walkanim, false);
        }
    }
}
