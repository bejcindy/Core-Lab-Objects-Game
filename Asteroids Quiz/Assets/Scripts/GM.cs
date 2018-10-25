using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour {
    GameObject level;
    public static int score;
    Text Scoring;
    int count, maxCount;
    float a, b, c, d;
    float x, y, r;
	// Use this for initialization
	void Start () {
        maxCount = 4;
        count = 0;
        Scoring = GameObject.Find("Score").GetComponent<Text>();
        score = 0;
        level = GameObject.Find("Image");
        //level.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        Scoring.text = "Score: " + score;
        if (count >= maxCount)
        {
            return;
        }
        count++;
        SpawnAsteroids();
        if (score >= 4){
            level.SetActive (true);
        }
    }

    public void SpawnAsteroids()
    {
        a = Random.Range(-8, -5);
        b = Random.Range(5, 8);
        c = Random.Range(3, 5);
        d = Random.Range(-5, -3);
        r = Random.value;
        if(0<=r&&r<=.25){
            x = a;
            y = c;
        } else if(.25<=r&&r<=.5){
            x = a;
            y = d;
        }else if(.5<=r&&r<=.75){
            x = b;
            y = c;
        }else{
            x = b;
            y = d;
        }
        Vector3 pos = new Vector3(Random.Range(-8, 8), Random.Range(5,-5), 0);
        Instantiate(Resources.Load("Asteroid"), pos, Quaternion.identity);
    }
}
