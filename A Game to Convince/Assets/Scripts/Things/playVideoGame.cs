using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playVideoGame : MonoBehaviour {
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
        t.value -= 4;
        GameManager.indoor += 4;
        GameManager.PVG = false;
        Destroy(this.gameObject);
    }
    // Update is called once per frame

}
