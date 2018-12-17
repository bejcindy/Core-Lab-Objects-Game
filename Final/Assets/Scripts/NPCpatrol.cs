using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCpatrol : MonoBehaviour {

    public float speed;
    public Transform[] moveSpots;
    int targetSpot;
    float disToSpot;

    float waitTime;
    float startWait;

    //public GameObject Player;

    //float chaseDist;
    void Start()
    {
        targetSpot = 0;
        disToSpot = 0.02f;

        startWait = 1f;
        waitTime = startWait;

        //chaseDist = 4;
    }


    void Update()
    {
        //if (Vector2.Distance(transform.position, Player.transform.position) < chaseDist)
       // {
            //transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);
       // }
        //else
       // {
            //partrol
            transform.position = Vector2.MoveTowards(transform.position, moveSpots[targetSpot].position, speed * Time.deltaTime);

            if (Vector2.Distance(transform.position, moveSpots[targetSpot].position) < disToSpot)
            {
                if (waitTime <= 0)
                {
                    targetSpot = Random.Range(0, moveSpots.Length);
                    //targetSpot++;
                    //if (targetSpot > moveSpots.Length - 1)
                    //{
                    //    targetSpot = 0;
                    //}
                    waitTime = startWait;
                }
                else { waitTime -= Time.deltaTime; }
            }
        //}
    }
}
