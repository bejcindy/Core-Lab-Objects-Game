using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    Slider e;
    Slider t;
    Text nEnergy;
    Text nTime;
    Text outvsin;
    GameObject StartScene;
    GameObject EndScene;
    public static bool cook;
    public static bool eat;
    public static bool HO;
    public static bool PVG;
    public static bool S;
    public static bool W;
    public static bool WTV;
    public static bool RAB;
    public static bool sleep;
    public static int outdoor;
    public static int indoor;

    // Use this for initialization
    void Start () {
        e = GameObject.Find("Energy").GetComponent<Slider>();
        t = GameObject.Find("Time").GetComponent<Slider>();
        nEnergy = GameObject.Find("EnergyNumber").GetComponent<Text>();
        nTime = GameObject.Find("TimeNumber").GetComponent<Text>();
        outvsin = GameObject.Find("OutvsIn").GetComponent<Text>();
        StartScene = GameObject.Find("StartingBackground");
        EndScene = GameObject.Find("Ending");
        cook = true;
        eat = true;
        HO = true;
        PVG = true;
        S = true;
        W = true;
        WTV = true;
        sleep = true;
        RAB = true;
        EndScene.SetActive(false);
        outdoor = 0;
        indoor = 0;
    }
	
	// Update is called once per frame
	void Update () {
        nEnergy.text = e.value + " /15";
        nTime.text = t.value + " /100";
        if(t.value<=0){
            outvsin.text=outdoor+" Hours    "+indoor+" Hours";
            EndScene.SetActive(true);
        }
        if(t.value%15<=0&&sleep==false){
            Vector2 r=new Vector2(Random.Range(2,6), Random.Range(2.5f,-3));
            Instantiate(Resources.Load("Sleep"), r, Quaternion.identity);
            Destroy(GameObject.FindWithTag("Things"));
            Destroy(GameObject.FindWithTag("Eat"));
            sleep = true;
            cook = false;
            eat = false;
            //HO = false;
            //PVG = false;
            //S = false;
            //W = false;
            //WTV = false;
            //RAB = false;
        }
        else{
            if (t.value % 5 <= 0 && cook == false && eat == false&&sleep==false){
                Vector2 r = new Vector2(Random.Range(2, 6), Random.Range(2.5f, -3));
                Instantiate(Resources.Load("CookInHome"), r, Quaternion.identity);
                cook = true;
                Vector2 l = new Vector2(Random.Range(-6, -2), Random.Range(2.5f, -3));
                Instantiate(Resources.Load("EatOutside"), l, Quaternion.identity);
                eat = true;
            }else if( e.value <= 0 && cook == false && eat == false && sleep == false)
            {
                Vector2 r = new Vector2(Random.Range(2, 6), Random.Range(2.5f, -3));
                Instantiate(Resources.Load("CookInHome"), r, Quaternion.identity);
                cook = true;
                Vector2 l = new Vector2(Random.Range(-6, -2), Random.Range(2.5f, -3));
                Instantiate(Resources.Load("EatOutside"), l, Quaternion.identity);
                eat = true;
                Destroy(GameObject.FindWithTag("Things"));
            }else if(e.value <= 0 && cook == true || e.value <= 0&& eat == true){
                Destroy(GameObject.FindWithTag("Things"));
                HO = false;
                PVG = false;
                S = false;
                W = false;
                WTV = false;
                RAB = false;
            }
            if(HO==false&&e.value>0){
                Vector2 l = new Vector2(Random.Range(-6, -2), Random.Range(2.5f, -3));
                Instantiate(Resources.Load("HangOut"), l, Quaternion.identity);
                HO = true;
            }
            if(PVG==false && e.value > 0)
            {
                Vector2 r = new Vector2(Random.Range(2, 6), Random.Range(2.5f, -3));
                Instantiate(Resources.Load("PlayVideoGame"), r, Quaternion.identity);
                PVG = true;
            }
            if(S==false && e.value > 0)
            {
                Vector2 l = new Vector2(Random.Range(-6, -2), Random.Range(2.5f, -3));
                Instantiate(Resources.Load("Shopping"), l, Quaternion.identity);
                S = true;
            }
            if(W==false && e.value > 0)
            {
                Vector2 l = new Vector2(Random.Range(-6, -2), Random.Range(2.5f, -3));
                Instantiate(Resources.Load("Walk"), l, Quaternion.identity);
                W = true;
            }
            if(WTV==false && e.value > 0)
            {
                Vector2 r = new Vector2(Random.Range(2, 6), Random.Range(2.5f, -3));
                Instantiate(Resources.Load("WatchTV"), r, Quaternion.identity);
                WTV = true;
            }
            if (RAB == false && e.value > 0)
            {
                Vector2 r = new Vector2(Random.Range(2, 6), Random.Range(2.5f, -3));
                Instantiate(Resources.Load("Read"), r, Quaternion.identity);
                RAB = true;
            }
        }
	}
}
