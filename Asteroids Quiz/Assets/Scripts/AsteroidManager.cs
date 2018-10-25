using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour {
    float s;
    int  a;
    float x, y;
    Vector2 p;
    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        s = Random.Range(1, 3);
        a = Random.Range(0, 360);
        Debug.Log("s value " + s);
        Debug.Log("a value " + a);
        if (a == 0)
        {
            a = Random.Range(-1, 1);
        }
        transform.Rotate(0, 0, a);
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        x = transform.position.x;
        y = transform.position.y;
        GetComponent<Rigidbody2D>().AddForce(transform.rotation * Vector2.up*s);
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, s);
        Debug.Log(rb.velocity);
        if (x>=8.5||x<=-8.5){
            transform.position=new Vector2(-x,y);
        }
        if(y >= 5.5 || y <= -5.5){
            transform.position = new Vector2(x, -y);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Bullet")){
            GM.score++;
            Destroy(this.gameObject);
        }
    }
}
