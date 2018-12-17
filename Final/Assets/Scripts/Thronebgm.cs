using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Thronebgm : MonoBehaviour {
    GameObject start;
    AudioSource bgm;
	// Use this for initialization
	void Start () {
        start = GameObject.Find("Button");
        bgm = GetComponent<AudioSource>();
	}

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // Update is called once per frame
    void Update () {
        if (start == null)
        {
            if (bgm.volume < 0.5f)
            {
                bgm.volume += Time.deltaTime;
            }
            else
            {
                bgm.volume = 0.5f;
            }
        }
    }

    void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
    {
        //if (scene.name == "StoryScene")
        //{
        //    bgm.volume -= Time.deltaTime;
        //    Destroy(gameObject);
        //    //Debug.Log("I am inside the if statement");
        //}
        if (bgm != null)
        {
            if (scene.name == "StoryScene")
            {
                bgm.volume -= Time.deltaTime;
                Destroy(gameObject);
                //Debug.Log("I am inside the if statement");
            }
        }
    }
}
