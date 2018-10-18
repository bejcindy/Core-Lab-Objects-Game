using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap : MonoBehaviour {
    Rigidbody2D rb;
    Animator anime;
    public float jump;
    public GameObject GameOver;
	// Use this for initialization
	void Start () {
        GameOver.SetActive(false);
        rb = GetComponent<Rigidbody2D>();
        anime = gameObject.GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space")){
            Vector2 up = transform.TransformDirection(Vector2.up);
            rb.AddForce(up * jump, ForceMode2D.Impulse);
            anime.SetTrigger("Active");
        }
        if(Input.GetMouseButtonDown(0)){
            Vector2 up = transform.TransformDirection(Vector2.up);
            rb.AddForce(up * jump, ForceMode2D.Impulse);
            anime.SetTrigger("Active");
        }
    }
    void OnTriggerEnter2D(Collider2D other){
        GameOver.SetActive(true);
        Destroy(this.gameObject);
    }
}
