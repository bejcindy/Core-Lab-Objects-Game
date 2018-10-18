using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour {
    public GameObject DownTube;
    public GameObject UpTube;
    public float speed;
    public float rate;
    public float delay;

    public static int n = 0;
    float d;
    float x;
    float h;
    float t;
    // Use this for initialization
    //void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    //{
    //    Debug.Log("On Level Finished Loading");
    //    //level = level+1;
    //}
    //private void OnEnable()
    //{
    //    Debug.Log("On Enable");
    //    SceneManager.sceneLoaded += OnSceneLoaded;
    //}

    //private void OnDisable()
    //{
    //    Debug.Log("On Disable");
    //    SceneManager.sceneLoaded -= OnSceneLoaded;
    //}
    void Start () {
        x = 3.5f;
        d = 8;
        //h = Random.Range(-2, 6);
	}
	
	// Update is called once per frame
	void Update () {
        //InvokeRepeating("SpawnTubes", 0.0f, 5.0f);
        //t= Time.deltaTime;
        //Debug.Log(t);
        if(n<=4 && Time.frameCount % 200 == 0)
        {
            //InvokeRepeating("SpawnTubes", 0.0f, 5.0f);
            //StartCoroutine("SpawnTubes", 5f);
            Invoke("SpawnTubes",2f);
            n++;
            //t = 0;
        }
	}



    void SpawnTubes(){
        h = Random.Range(2, 6);
        Vector2 pos = new Vector2(x, h);
        Instantiate(DownTube, pos, Quaternion.identity);
        Vector2 poss = new Vector2(x, h - d);
        Instantiate(UpTube, poss, Quaternion.identity);
        //yield return new WaitForSeconds(3.0f);
        //x -= speed;
    }
}
