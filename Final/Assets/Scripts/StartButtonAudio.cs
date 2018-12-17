using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonAudio : MonoBehaviour {

	public void Sound()
    {
        AudioSource der = GetComponent<AudioSource>();
        der.Play();
    }
}
