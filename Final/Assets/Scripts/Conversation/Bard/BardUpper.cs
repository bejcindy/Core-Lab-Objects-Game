using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BardUpper : MonoBehaviour {
    public GameObject lower;
    private void Start()
    {
        lower.SetActive(false);
    }
    public void Talk()
    {
        Text dialogue = GameObject.Find("Dialogue").GetComponent<Text>();
        Text up = GameObject.Find("Up").GetComponent<Text>();
        AudioSource der = GetComponent<AudioSource>();
        der.Play();
        DataHolder.up++;
        if (DataHolder.up == 1)
        {
            dialogue.fontSize = 48;
            dialogue.text = "The Kingdom used to\nhave two princes:\nprince Gabriel and\nprince George.";
            up.text = "...";
        }
        if (DataHolder.up == 2)
        {
            dialogue.text = "They grew up together.\nOne became brave and \none became smart.";
        }
        if (DataHolder.up == 3)
        {
            dialogue.fontSize = 42;
            dialogue.text = "Gabriel won countless battle\r\nfor the kingdom with his courage,\r\nwhile George read his books\r\nand talked with the people.";
        }
        if (DataHolder.up == 4)
        {
            dialogue.text = "Many believed that one day\nGabriel would become the King.\nBut the old King passed his\ncrown to George.";
        }
        if (DataHolder.up == 5)
        {
            dialogue.text = "Gabriel, after all he had done\nfor the Kingdom, wasn't satisfied\nby the Old King's decision.";
        }
        if (DataHolder.up == 6)
        {
            dialogue.text = "He tried to usurp the throne,\nbut failed after defeated by King\nGeorge.";
        }
        if (DataHolder.up == 7)
        {
            dialogue.text = "King George banished prince\nGabriel. But some rumors said \nthat the one on the throne right\nnow is no one but actually Gabriel...";
        }
        if (DataHolder.up == 8)
        {
            dialogue.text = "His ambition gave him the desire\r\nto rule. But people love their \nold King\r and George. So he \ndisguised as King George\nin order to rule legitimately.";
        }
        if (DataHolder.up == 9)
        {
            dialogue.text = "But rumors are rumors, \nwe would never know if \nthat's true or not.And \nthat will be too much for \na story to tell for now.";
            up.fontSize = 32;
            up.text = "Sorry, I didn't pay attention";
            lower.SetActive(true);
        }
        if (DataHolder.up == 10)
        {
            dialogue.text = "... Fine, I'll sing it again";
            up.text = "...";
            lower.SetActive(false);
            DataHolder.up = 0;
        }
    }
}
