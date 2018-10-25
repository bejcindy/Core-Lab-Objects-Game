using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    GameObject level;
    public float s;
    public float rs;
    float x, y;
    Vector2 p;
    Quaternion r;
	// Use this for initialization
	void Start () {
        level = GameObject.Find("Restart");
    }
	
	// Update is called once per frame
	void Update () {
        p = transform.Find("Point").transform.position;
        r = transform.rotation;
        x = transform.position.x;
        y = transform.position.y;
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 0));
        if (Input.GetKey(KeyCode.UpArrow)){
            GetComponent<Rigidbody2D>().AddForce(transform.rotation*Vector2.up * s);
        }
        if (Input.GetKey(KeyCode.DownArrow)){
            GetComponent<Rigidbody2D>().AddForce(transform.rotation*Vector2.down * s);
        }
        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.Rotate(0,0, rs);
        }
        if (Input.GetKey(KeyCode.RightArrow)){
            transform.Rotate(0,0, -rs);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(Resources.Load("Bullet"), p, r);
        }
        if (x >= 8.25 || x <= -8.25)
        {
            transform.position = new Vector2(-x, y);
        }
        if (y >= 5.25 || y <= -5.25)
        {
            transform.position = new Vector2(x, -y);
        }
    }
    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Asteroid")){
            //level.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}
