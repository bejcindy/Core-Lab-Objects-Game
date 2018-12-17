using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrolltrigger : MonoBehaviour {

    public GameManager gameManager;
    public string sceneNum;
    public Color loadToColor;
    public GameObject player;
    public GameObject filter;
    AudioSource der;
    void Start()
    {
        der = GetComponent<AudioSource>();
        filter.SetActive(false);
        if (DataHolder.scroll == true)
        {
            player.transform.position = new Vector2(DataHolder.playerX, player.transform.position.y);
            filter.SetActive(true);
            Destroy(GameObject.FindWithTag("Scroll"));
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            der.Play();
            DataHolder.playerX = other.transform.position.x;
            DataHolder.scroll = true;
            Initiate.Fade(sceneNum, loadToColor, 1.0f);
        }
    }
}
