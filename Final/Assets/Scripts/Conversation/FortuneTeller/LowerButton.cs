using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LowerButton : MonoBehaviour {

    public void Talk()
    {
        Text dialogue = GameObject.Find("Dialogue").GetComponent<Text>();
        Text up = GameObject.Find("Up").GetComponent<Text>();
        Text down = GameObject.Find("Down").GetComponent<Text>();
        GameObject lower = GameObject.Find("Lower");
        AudioSource der = GetComponent<AudioSource>();
        der.Play();
        DataHolder.down++;

        if (DataHolder.down == 1)
        {
            dialogue.text = "About your past or future ?";
            up.text = "Past";
            down.text = "Future";
        }
        if (DataHolder.down == 2)
        {
            dialogue.fontSize = 42;
            dialogue.text = "Your future is filled with blood \nand suffering, I wonder what's \nthe cause of that...";
            up.text = "Hmmm . . .";
            lower.SetActive(false);
        }
        if (DataHolder.down == 1 && DataHolder.up == 1)
        {
            dialogue.fontSize = 42;
            dialogue.text = "The King will soon meets his fate, \nI can see nothing but darkness\nin his future...";
            up.text = ". . .";
            lower.SetActive(false);
        }
    }
}