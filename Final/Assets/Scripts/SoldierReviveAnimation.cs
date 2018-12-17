using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierReviveAnimation : MonoBehaviour {

    Animator a;
    bool revive;
    bool lay;
    bool c;

	// Use this for initialization
	void Start () {
        a = GetComponent<Animator>();
        revive = false;
        lay = false;
        c = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Debug.Log("revive " + revive + " , lay " + lay);
        if (c == true && Input.GetKey(KeyCode.A))
        {
            revive = true;
            lay = false;
        }
        if (c == true && Input.GetKey(KeyCode.D))
        {
            revive = false;
            lay = true;
        }
        if (c == false)
        {
            revive = false;
            lay = false;
        }
        if (revive == true)
        {
            a.SetBool("Revive", true);
        }
        else { a.SetBool("Revive", false); }
        if (lay == true)
        {
            a.SetBool("Lay", true);
        }
        else { a.SetBool("Lay", false); }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            c = true;
            Debug.Log("player detected");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            c = false;
            Debug.Log("player detected");
        }
    }
}
