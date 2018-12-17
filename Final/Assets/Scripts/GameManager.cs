using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public int scenenum;

    
    // Use this for initialization
    public void Talk()
    {
        SceneManager.LoadScene(scenenum);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
