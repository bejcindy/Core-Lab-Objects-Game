using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnScene2 : MonoBehaviour {

    public string scene;
    public Color loadToColor = Color.black;

    public void GoFade()
    {
        Initiate.Fade(scene, loadToColor, 1.0f);
    }
}
