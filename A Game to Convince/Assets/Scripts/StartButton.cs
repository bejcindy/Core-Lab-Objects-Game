using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour {

    public void StartGame(){
        GameObject StartScene = GameObject.Find("StartingBackground");
        StartScene.SetActive(false);
    }
}
