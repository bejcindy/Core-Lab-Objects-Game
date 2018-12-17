using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldierMovement : MonoBehaviour {
    public float speed;
    private Rigidbody rb;
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	
	void Update () {
        transform.localPosition -= transform.right * speed * Time.deltaTime;
    }
}
