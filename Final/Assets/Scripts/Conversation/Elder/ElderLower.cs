using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElderLower : MonoBehaviour {
    public void Talk()
    {
        Text dialogue = GameObject.Find("Dialogue").GetComponent<Text>();
        Text up = GameObject.Find("Up").GetComponent<Text>();
        Text down = GameObject.Find("Down").GetComponent<Text>();
        GameObject lower = GameObject.Find("Lower");
        AudioSource der = GetComponent<AudioSource>();
        der.Play();
        DataHolder.down++;
        if(DataHolder.down + DataHolder.up == 1)
        {
            dialogue.text = "I’m the “client” of\nTHE BUSINESS !";
            up.text = "Great";
            down.text = "AHA !";
        }
        if (DataHolder.down + DataHolder.up == 2)
        {
            dialogue.fontSize = 42;
            dialogue.text = "Let's make sure we're both\nlooking for the right person .\nYou are here for the job\nabout the King, right ?";
            up.text = "Yes";
            down.text = "What . . . ?";
        }
        if (DataHolder.down + DataHolder.up == 3)
        {
            dialogue.fontSize = 48;
            dialogue.text = "Oh . . . then I think\nyou are not the person\nthat I’m looking for . . .";
            up.text = "Nah Just Kidding.";
            lower.SetActive(false);
        }
    }
}
