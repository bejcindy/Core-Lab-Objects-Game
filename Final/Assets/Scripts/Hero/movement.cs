using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public float val;
    public GameObject cam;
    public GameObject E;
	void Start () {
        //E = GameObject.Find("e");
        E.SetActive(false);
    }

    private void Awake()
    {
        E.SetActive(false);
    }

    void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.left * val);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * val);
        }
        if((transform.position.x- cam.transform.position.x)>2.7f){
            transform.position = new Vector3(cam.transform.position.x + 2.7f, transform.position.y, transform.position.z);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("NPC"))
        {
            E.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("NPC"))
        {
            E.SetActive(false);
        }
    }

}
