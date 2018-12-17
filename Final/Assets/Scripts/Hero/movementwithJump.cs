using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementwithJump : MonoBehaviour {
    public float val;
    public GameObject cam;
    private Rigidbody2D rb;
    
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.left * val);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * val);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector2(0f, 4f);
        }
        if ((transform.position.x - cam.transform.position.x) > 4.5f)
        {
            transform.position = new Vector3(cam.transform.position.x + 4.5f, transform.position.y, transform.position.z);
        }
        if((transform.position.x - cam.transform.position.x) < -4.5f)
        {
            transform.position = new Vector3(cam.transform.position.x - 4.5f, transform.position.y, transform.position.z);
        }
    }
}

