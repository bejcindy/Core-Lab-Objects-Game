using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AlwaysThere : MonoBehaviour {
    GameObject levelImage;
    public static float level;
    public float LevelStartDelay = 1f;
    private Text levelText;
    private void Awake()
    {
        level = -1;
        levelText = GameObject.Find("LevelNumber").GetComponent<Text>();
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("On Level Finished Loading");
        //level = level+1;
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
        //level++;
        AlwaysThere.level = AlwaysThere.level + 1;
        //Set the text of levelText to the string "Day" and append the current level number.
        levelText.text = "Level " + AlwaysThere.level;
        //levelText.text = "Roll to the Exit !";

        //Set levelImage to active blocking player's view of the game board during setup.
        levelImage.SetActive(true);

        //Call the HideLevelImage function with a delay in seconds of levelStartDelay.
        Invoke("HideLevelImage", LevelStartDelay);

    }

    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(this.gameObject);
        levelImage = GameObject.Find("LevelImage");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
