using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAnimation : MonoBehaviour {

    Animator a;
    bool left;
    bool right;

	// Use this for initialization
	void Start () {
        a = GetComponent<Animator>();
        left = false;
        right = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.A))
        {
            left = true;
        }
        else { left = false; }

        if (Input.GetKey(KeyCode.D))
        {
            right = true;
        }
        else { right = false; }
        //Debug.Log("left "+p_MovingLeft);
        //Debug.Log("right " + p_MovingRight);
        if (left == true)
        {
            a.SetBool("MovingLeft", true);
        }
        else { a.SetBool("MovingLeft", false); }
        if (right == true)
        {
            a.SetBool("MovingRight", true);
        }
        else { a.SetBool("MovingRight", false); }
    }
}
