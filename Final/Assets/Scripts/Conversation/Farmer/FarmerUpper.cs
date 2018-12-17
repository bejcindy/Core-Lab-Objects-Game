using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FarmerUpper : MonoBehaviour
{
    public void Talk()
    {
        Text dialogue = GameObject.Find("Dialogue").GetComponent<Text>();
        Text up = GameObject.Find("Up").GetComponent<Text>();
        AudioSource der = GetComponent<AudioSource>();
        der.Play();
        DataHolder.up++;
        if (DataHolder.up == 1)
        {
            dialogue.text = "Not really well...";
            up.text = "What happened ?";
        }
        if (DataHolder.up == 2)
        {
            dialogue.text = "The King raised the tax\nagain... People say he is\n preparing another war.";
            up.text = "Oh . . .";
        }
        if (DataHolder.up == 3)
        {
            dialogue.text = "He used to care about and\n be kind to his people, but . . .";
            up.text = "But ?";
        }
        if (DataHolder.up == 4)
        {
            dialogue.fontSize = 40;
            dialogue.text = "Now it seems like the only thing he\nwants is winning glories for his army\n and himself on the battlefield. . .";
            up.text = ". . .";
        }
        if (DataHolder.up == 5)
        {
            dialogue.fontSize = 48;
            dialogue.text = "It feels like he is influenced\nby his banished brother...";
        }
        if (DataHolder.up == 6)
        {
            dialogue.text = "*sign*";
            up.text = "Good bye";
        }
        if (DataHolder.up == 7)
        {
            DataHolder.up = 0;
            Initiate.Fade("StoryScene", Color.black, 1.0f);
        }
    }
}
