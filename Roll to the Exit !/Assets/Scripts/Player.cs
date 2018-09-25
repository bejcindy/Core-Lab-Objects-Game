using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public float speed;
    public float LevelStartDelay = 1f;
    public float jump;

    private Rigidbody rb;
    private GameObject levelImage;
    private Text levelText;
    private int level = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        levelImage = GameObject.Find("LevelImage");
        levelText = GameObject.Find("LevelNumber").GetComponent<Text>();
        //level = 0;
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
        level = level + 1;
        //Set the text of levelText to the string "Day" and append the current level number.
        //levelText.text="Level "+level;
        levelText.text = "Roll to the Exit !";

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

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
        //if (Input.GetKeyDown("space"))
        //{
        //    Vector3 up = transform.TransformDirection(Vector3.up);
        //    rb.AddForce(up * jump, ForceMode.Impulse);
        //}
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            Debug.Log("Hit Spikes");
            levelImage.SetActive(true);
            levelText.text = "You Lose";
        }

        if (other.gameObject.CompareTag("Exit"))
        {
            Debug.Log("Exit");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}