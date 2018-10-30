using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cookInHome : MonoBehaviour {
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
        e.value += 5;
        t.value -= 2;
        GameManager.indoor += 2;
        GameManager.cook = false;
        Destroy(this.gameObject);
    }

}
