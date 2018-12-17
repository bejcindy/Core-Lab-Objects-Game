using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoldierUpper : MonoBehaviour {
    public GameObject lower;

    public void Talk()
    {
        Text dialogue = GameObject.Find("Dialogue").GetComponent<Text>();
        Text up = GameObject.Find("Up").GetComponent<Text>();
        AudioSource der = GetComponent<AudioSource>();
        der.Play();
        DataHolder.up++;
        if (DataHolder.up == 1 && DataHolder.down == 0)
        {
            Text down = GameObject.Find("Down").GetComponent<Text>();
            dialogue.text = "Well . . .";
            up.text = "I wasn't sure about this at first";
            down.text = "He paid me well so . . .";
        }
        if (DataHolder.up == 2 && DataHolder.down == 0)
        {
            dialogue.text = ". . .";
            up.text = "But I met people on my way here";
            lower.SetActive(false);
        }
        if (DataHolder.up == 3 && DataHolder.down == 0)
        {
            dialogue.text = "And ?";
            up.text = "He is not actually your king";
        }
        if (DataHolder.up == 4 && DataHolder.down == 0)
        {
            dialogue.text = "Nonsense !";
            up.text = "(Tell him what you know)";
        }
        if (DataHolder.up == 5 && DataHolder.down == 0)
        {
            dialogue.text = "I'm so confused . . .";
            up.text = "( RUN ! )";
        }
        if (DataHolder.up == 6 && DataHolder.down == 0)
        {
            Initiate.Fade("Ending", Color.white, 1.0f);
        }
        if (DataHolder.up == 1 && DataHolder.down == 1)
        {
            dialogue.text = "Well . . .";
            up.text = "I wasn't sure about thist at first";
            lower.SetActive(false);
            DataHolder.down = 0;
        }
        if (DataHolder.up == 1 && DataHolder.down == 2)
        {
            dialogue.text = "And ?";
            up.text = "He is not actually your king";
            lower.SetActive(false);
            DataHolder.up = 3;
            DataHolder.down = 0;
        }
        if (DataHolder.up == 1 && DataHolder.down == 4)
        {
            Initiate.Fade("Ending 1", Color.white, 1.0f);
        }
        if (DataHolder.up == 2 && DataHolder.down == 1)
        {
            Initiate.Fade("Ending 1", Color.black, 1.0f);
        }
        if (DataHolder.up == 1 && DataHolder.down == 3)
        {
            Initiate.Fade("Ending", Color.white, 1.0f);
        }
    }
}
