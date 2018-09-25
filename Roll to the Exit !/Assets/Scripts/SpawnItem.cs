using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnItem : MonoBehaviour {
    public float LevelStartDelay = 2f;
    public GameObject spikes;
    public Vector3 center;
    public Vector3 size;
    public int min;
    public int max;
    public static SpawnItem instance = null;

    private float maxCount;
    private int count;
    //private Vector3 pos;

    private Text levelNumber;



    private void Start()
    {
        maxCount = Random.Range(min, max);
        count = 0;
    }

    void Update()
    {
        Spikes();
    }

    public void Spikes(){
        if (count >= maxCount)
        {
            return;
        }
        //Vector3 pos = new Vector3(Random.Range(-4, 5), -0.23f, Random.Range(-4, 5));
        count++;
        SpawnSpikes();
    }

    public void SpawnSpikes(){
        Vector3 pos = new Vector3(Random.Range(-3, 4), -0.23f, Random.Range(-3, 4));
        Instantiate(spikes, pos, Quaternion.identity);
    }

}
