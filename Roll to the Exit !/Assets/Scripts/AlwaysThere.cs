using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AlwaysThere : MonoBehaviour {
    public float LevelStartDelay = 1f;

    private GameObject levelImage;
    private Text levelText;
    private int level=0;
    private void Awake()
    {
        DontDestroyOnLoad(GameObject.Find("AlwaysThere"));
        //DontDestroyOnLoad(GameObject.Find("Canvas"));
        //level = 0;
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("On Level Finished Loading");
        //level++;
        InitGame();
    }
    private void OnEnable()
    {
        Debug.Log("On Enable");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        Debug.Log("On Disable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void InitGame()
    {
        Debug.Log("InitGame");

        //Get a reference to our image LevelImage by finding it by name.
        levelImage = GameObject.Find("LevelImage");

        //Get a reference to our text LevelText's text component by finding it by name and calling GetComponent.
        levelText = GameObject.Find("LevelNumber").GetComponent<Text>();
        level++;
        //Set the text of levelText to the string "Day" and append the current level number.
        levelText.text = "Level " + level;

        //Set levelImage to active blocking player's view of the game board during setup.
        levelImage.SetActive(true);

        //Call the HideLevelImage function with a delay in seconds of levelStartDelay.
        Invoke("HideLevelImage", LevelStartDelay);

    }

    void HideLevelImage()
    {
        Debug.Log("Hide Level Image");
        //Disable the levelImage gameObject.
        levelImage.SetActive(false);
    }

    // Use this for initialization
    void Start () {
        levelImage = GameObject.Find("LevelImage");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
