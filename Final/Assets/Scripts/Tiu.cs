using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiu : MonoBehaviour {
    AudioSource tiu;
    // Use this for initialization
    void Start () {
        tiu = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (Input.GetKeyDown("e"))
            {
                tiu.Play();
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            tiu.Play();
        }
    }
}
