using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returnScene : MonoBehaviour {

    public string scene;
    public Color loadToColor = Color.white;

    public void GoFade()
    {
        Initiate.Fade(scene, loadToColor, 1.0f);
        
    }
}
