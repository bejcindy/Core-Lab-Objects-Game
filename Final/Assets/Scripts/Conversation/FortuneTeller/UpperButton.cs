using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpperButton : MonoBehaviour {

    public void Talk()
    {
        Text dialogue = GameObject.Find("Dialogue").GetComponent<Text>();
        Text up = GameObject.Find("Up").GetComponent<Text>();

        GameObject lower = GameObject.Find("Lower");
        AudioSource der = GetComponent<AudioSource>();
        der.Play();
        DataHolder.up++;

        if (DataHolder.up == 1 && DataHolder.down==0)
        {
            Text down = GameObject.Find("Down").GetComponent<Text>();
            dialogue.text = "About his past or future ?";
            up.text = "Past";
            down.text = "Future";
        }
        if (DataHolder.up == 2 && DataHolder.down==0)
        {
            dialogue.text = "The King used to \nbe a different person ...";
            up.text = "Interesting . . .";
            lower.SetActive(false);
        }
        if (DataHolder.up == 1 && DataHolder.down == 1)
        {
            dialogue.fontSize = 42;
            dialogue.text = "The last time you wet your bed \nwas 10 years ago. hmmmmmm.... \nhow old are you now?";
            up.text = "Interesting . . .";
            lower.SetActive(false);
        }
        if (DataHolder.up == 3)
        {
            DataHolder.up = 0;
            DataHolder.down = 0;
            Initiate.Fade("StoryScene", Color.black, 1.0f);
        }
        if (DataHolder.up == 2 && DataHolder.down==1)
        {
            DataHolder.up = 0;
            DataHolder.down = 0;
            Initiate.Fade("StoryScene", Color.black, 1.0f);
        }
        if (DataHolder.up == 1 && DataHolder.down == 2)
        {
            DataHolder.up = 0;
            DataHolder.down = 0;
            Initiate.Fade("StoryScene", Color.black, 1.0f);
        }
    }
}
