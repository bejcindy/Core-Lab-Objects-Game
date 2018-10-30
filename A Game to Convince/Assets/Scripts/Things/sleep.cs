using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sleep : MonoBehaviour {
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
        e.value += 10;
        t.value -= 8;
        GameManager.sleep = false;
        Destroy(this.gameObject);
    }

}
