using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTrigger : MonoBehaviour {
    public string scene;
    public Color loadToColor = Color.white;
    public GameObject player;
    AudioSource der;
    AudioSource bgm;
    // Use this for initialization
    void Start () {
        der = GetComponent<AudioSource>();
        bgm = GameObject.Find("bgmHolder").GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            bgm.volume -= Time.deltaTime;
            der.Play();
            Initiate.Fade(scene, loadToColor, 1.0f);
        }
    }
}
