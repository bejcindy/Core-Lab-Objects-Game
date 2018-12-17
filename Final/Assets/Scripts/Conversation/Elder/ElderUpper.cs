using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElderUpper : MonoBehaviour {

    public GameObject lower;

    public void Talk() {
        Text dialogue = GameObject.Find("Dialogue").GetComponent<Text>();
        Text up = GameObject.Find("Up").GetComponent<Text>();
        AudioSource der = GetComponent<AudioSource>();
        der.Play();
        DataHolder.up++;
        if (DataHolder.up + DataHolder.down==1)
        {
            Text down = GameObject.Find("Down").GetComponent<Text>();
            dialogue.text = "Great, let's talk about\nthe contract before you\nstart your work .";
            up.text = "Great";
            down.text = "AHA !";
        }
        if (DataHolder.up + DataHolder.down==2)
        {
            Text down = GameObject.Find("Down").GetComponent<Text>();
            dialogue.text = "Let's make sure we're both\nlooking for the right person .\nYou are here for the job\nabout the King, right ?";
            up.text = "Yes";
            down.text = "What . . . ?";
        }
        if (DataHolder.up + DataHolder.down == 3)
        {
            dialogue.text = "Great . . . I heard you are\nreally professional and will do\nanything with the right price .";
            up.text = "That's right";
            lower.SetActive(false);
        }
        if (DataHolder.up + DataHolder.down == 4)
        {
            dialogue.fontSize = 48;
            dialogue.text = "Perfect, I think you’ve\nalready know what you need\nto do from my assistance.\nKill King George.";
            up.text = "I know";
        }
        if (DataHolder.up + DataHolder.down == 5)
        {
            dialogue.fontSize = 48;
            dialogue.text = "Here’s half of the payment.\nKill him and bring his ring\nback to me to get the other\nhalf of the money.";
            up.text = "( Take the money )";
        }
        if (DataHolder.up + DataHolder.down == 6)
        {
            dialogue.fontSize = 48;
            dialogue.text = "Safe travel, I will be\nwaiting for your good news.";
            up.text = "Good Bye";
        }
        if (DataHolder.up + DataHolder.down == 7)
        {
            DataHolder.up = 0;
            DataHolder.down = 0;
            Initiate.Fade("Throne 1", Color.black, 1.0f);
        }
    }
}
