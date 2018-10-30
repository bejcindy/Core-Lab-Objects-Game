using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class walk : MonoBehaviour {
    Slider e;
    Slider t;
    // Use this for initialization
    void Start()
    {
        e = GameObject.Find("Energy").GetComponent<Slider>();
        t = GameObject.Find("Time").GetComponent<Slider>();
    }
    private void OnMouseDown()
    {
        e.value -= 2;
        t.value -= 1;
        GameManager.outdoor += 1;
        GameManager.W = false;
        Destroy(this.gameObject);
    }

}
