using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hangOut : MonoBehaviour {
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
        e.value -= 3;
        t.value -= 3;
        GameManager.outdoor += 3;
        GameManager.HO = false;
        Destroy(this.gameObject);
    }

}
