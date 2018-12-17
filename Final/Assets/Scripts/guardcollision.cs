using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class guardcollision : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public string sceneNum;
    public Color loadToColor;
    public GameObject player;
    bool stop;
    AudioSource bgm;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        stop = false;
        bgm = GameObject.Find("bgmHolder").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (stop == false)
        {
            transform.localPosition -= transform.right * speed * Time.deltaTime;
        }
        else { transform.localPosition = transform.localPosition; }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            stop = true;
            bgm.volume -= Time.deltaTime;
            Initiate.Fade(sceneNum, loadToColor, 1.0f);
        }
        if (other.gameObject.CompareTag("Stop"))
        {
            stop = true;

        }
    }
}

