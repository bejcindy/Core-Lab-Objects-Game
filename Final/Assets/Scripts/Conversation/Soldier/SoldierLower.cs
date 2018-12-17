using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoldierLower : MonoBehaviour {
    public void Talk()
    {
        Text dialogue = GameObject.Find("Dialogue").GetComponent<Text>();
        Text up = GameObject.Find("Up").GetComponent<Text>();
        Text down = GameObject.Find("Down").GetComponent<Text>();
        GameObject lower = GameObject.Find("Lower");
        AudioSource der = GetComponent<AudioSource>();
        der.Play();
        DataHolder.down++;
        if (DataHolder.up == 0 && DataHolder.down == 1)
        {
            dialogue.text = "Wait what ?";
            up.text = "And I met an old man";
            down.text = "I didn't know what was going on";
        }
        if (DataHolder.up == 0 && DataHolder.down == 2)
        {
            dialogue.text = "? ? ?";
            up.text = "So I asked people";
            down.text = "And I came to the castle";
        }
        if (DataHolder.up == 0 && DataHolder.down == 3)
        {
            dialogue.text = "? ? ? ? ? ?";
            up.text = "( RUN ! )";
            down.text = "The King scared me";
        }
        if (DataHolder.up == 0 && DataHolder.down == 4)
        {
            dialogue.text = "? ? ? ? ? ? ? ? ?";
            up.text = "So I killed him";
            lower.SetActive(false);
        }
        if (DataHolder.up == 1 && DataHolder.down == 1)
        {
            dialogue.text = "So you came and kill the King ?";
            up.text = "Yeah . . .";
            lower.SetActive(false);
        }

    }
}
