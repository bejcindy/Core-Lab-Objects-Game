using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour {

    GameObject level;
    GameObject levell;
    private void Start()
    {
        level = GameObject.Find("Startt");
    }
    public void StartGame(){
        level.SetActive(false);
    }
}
