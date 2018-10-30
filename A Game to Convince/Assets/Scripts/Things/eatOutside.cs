using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eatOutside : MonoBehaviour {
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
        e.value += 4;
        t.value -= 2;
        GameManager.outdoor += 2;
        GameManager.eat = false;
        Destroy(this.gameObject);
    }

}
