using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DataHolder.playerX = 0;
            DataHolder.up = 0;
            DataHolder.down = 0;
            DataHolder.scroll = false;
            Initiate.Fade("Start", Color.black, 1.0f);
        }
    }
}
