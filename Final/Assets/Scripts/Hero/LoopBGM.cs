using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopBGM : MonoBehaviour {
    AudioSource bgm;
    bool fade;
    // Use this for initialization
    void Start () {
        bgm = GetComponent<AudioSource>();
        bgm.volume = 0;
        bgm.Play();
        fade = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (fade == true)
        {
            if (bgm.volume > 0.01f)
            {
                bgm.volume -= Time.deltaTime;
            }
            else
            {
                bgm.volume = 0;
            }
        }
        else if(bgm.volume<0.5f && fade==false)
        {
            bgm.volume += Time.deltaTime;
        }
        else
        {
            bgm.volume = 0.5f;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("NPC"))
        {
            if (Input.GetKeyDown("e"))
            {
                fade = true;
            }
        }
    }
}
