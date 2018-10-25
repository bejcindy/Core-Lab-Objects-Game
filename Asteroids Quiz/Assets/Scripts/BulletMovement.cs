using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {
    public float s;
    float x, y;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        x = transform.position.x;
        y = transform.position.y;
        GetComponent<Rigidbody2D>().AddForce(transform.rotation * Vector2.up * s);
        if (x >= 8.25 || x <= -8.25)
        {
            Destroy(this.gameObject);
        }
        if (y >= 5.25 || y <= -5.25)
        {
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Asteroid"))
        {
            Destroy(this.gameObject);
        }
    }
}
