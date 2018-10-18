using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast2D : MonoBehaviour {

    public LineRenderer LR; 

	// Use this for initialization
	void Start () {
        LR = GetComponent<LineRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        

        if (Input.GetMouseButtonDown(0))
        {
            LR.enabled = true;
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 5f;

            Vector2 v = Camera.main.ScreenToWorldPoint(mousePosition);

            Collider2D[] col = Physics2D.OverlapPointAll(v);

            //Display Line
            LR.SetPosition(0, transform.position);
            LR.SetPosition(1, v);

            //Debug.DrawRay(transform.position, v);

            if (col.Length > 0)
            {
                foreach (Collider2D c in col)
                {
                    if (c.tag == "Enemy")
                    {
                        Destroy(c.gameObject);
                        SpawnEnemy.count--;
                        SpawnEnemy.n++;
                    }
                    Debug.Log("Collided with: " + c.GetComponent<Collider2D>().gameObject.name);
                    //targetPos = c.collider2D.gameObject.transform.position;
                }
            }

        }
        else
        {
            LR.enabled = false;
        }



    }
}
