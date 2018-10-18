using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnEnemy : MonoBehaviour {
    public GameObject enemy;
    public int max, min;
    Text numberDisplay;

    public static int count;
    int maxCount;
    public static int n;
    // Use this for initialization
    void Start () {
        maxCount = Random.Range(min, max);
        count = 0;
        n = 0;
        numberDisplay = GameObject.Find("number").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        Enemies();
        numberDisplay.text = "Killed: " + n;
    }
    public void Enemies()
    {
        if (count >= maxCount)
        {
            return;
        }
        //Vector3 pos = new Vector3(Random.Range(-4, 5), -0.23f, Random.Range(-4, 5));
        count++;
        SpawnEnemies();
        numberDisplay.text = "Killed: " + n;
    }
    public void SpawnEnemies()
    {
        Vector2 pos = new Vector2(Random.Range(-8, 8), Random.Range(-4, 4));
        Instantiate(enemy, pos, Quaternion.identity);
    }
}
