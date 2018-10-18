using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour {
    float x;
    float y;
	// Use this for initialization
	void Start () {
        x = transform.position.x;
        y = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.left * Time.deltaTime);
        //if(x<=-3.5f){
        //    GM.n--;
        //    Destroy(this.gameObject);
        //}
    }
    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("LeftBoarder")){
            GM.n--;
            Destroy(this.gameObject);
        }
    }
}
