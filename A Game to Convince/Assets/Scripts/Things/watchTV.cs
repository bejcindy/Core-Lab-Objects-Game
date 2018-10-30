using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class watchTV : MonoBehaviour {
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
        e.value -= 1;
        t.value -= 2;
        GameManager.indoor += 2;
        GameManager.WTV = false;
        Destroy(this.gameObject);
    }


}
