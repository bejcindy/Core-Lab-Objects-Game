using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TalkTrigger : MonoBehaviour {
    public string sceneNum;
    public Color loadToColor;
    public GameObject player;
    void Start () {
        player.transform.position = new Vector2(DataHolder.playerX-2,player.transform.position.y);
        
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("Player")){
            if (Input.GetKeyDown("e"))
            {
                DataHolder.playerX = other.transform.position.x;
                Initiate.Fade(sceneNum, loadToColor, 1.0f);
            }
            
        }
    }
}
