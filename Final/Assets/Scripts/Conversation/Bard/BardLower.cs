using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BardLower : MonoBehaviour {
    public void Leave()
    {
        AudioSource der = GetComponent<AudioSource>();
        der.Play();
        DataHolder.up = 0;
        DataHolder.down = 0;
        Initiate.Fade("StoryScene", Color.black, 1.0f);
    }
}
