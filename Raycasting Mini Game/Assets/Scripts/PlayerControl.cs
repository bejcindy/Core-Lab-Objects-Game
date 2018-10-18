using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    public float speed;
    public Transform GunEnd;
    private LineRenderer LaserLine;

    // Use this for initialization
    void Start () {
        LaserLine = GunEnd.GetComponent<LineRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        //Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //mouse.z = 0;
        if (Input.GetButton("Fire1"))
        {
            RaycastHit2D hit; // information about raycast collision

            LaserLine.enabled = true;
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 5f;

            Vector2 v = Camera.main.ScreenToWorldPoint(mousePosition);
            LaserLine.SetPosition(0, GunEnd.position);
            LaserLine.SetPosition(1, v);
            Debug.DrawRay(GunEnd.position, v,Color.red);
            //Debug.Log(mouse);

            hit = Physics2D.Raycast(GunEnd.position, v);
            if (hit.collider != null) // if collider exists
            {
                Debug.Log(hit.collider.name);
                //LaserLine.SetPosition(1, hit.point);
                if (hit.collider.tag == "Enemy")
                {
                    hit.collider.GetComponent<SpriteRenderer>().color = Color.blue;
                }
            }

        }else{
            LaserLine.enabled = false;
        }
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 0));
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * speed/2,ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.down * speed);
        }
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 0));
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.left * speed);
        }
    }
    // @NOTE Must be called from FixedUpdate() to work properly
   
}
