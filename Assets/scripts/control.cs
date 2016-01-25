using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class control : MonoBehaviour {
    public GameObject kale;
    float x;
    static public int score;
    static public int lives;
    public static bool reset;
    public GameObject pause;
    public GameObject lose;
    public GameObject e1;
    public GameObject e2;
    public GameObject e3;
    public GameObject e4;
    public double choice;
    bool paused;
    bool lost;
	// Use this for initialization
	void Start () {
        lives = 3;
        Invoke("Spawn", .5f);
        reset = false;
        paused = false;
        lost = false;
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
	if(reset == true)
        {
            Invoke("res", 3f);
        }
        if (Input.GetKeyDown(KeyCode.Return) && paused == false)
        {
            Time.timeScale = 0f;
            pause.GetComponent<CanvasGroup>().alpha = 1f;
            paused = true;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && paused == true)
        {
            Time.timeScale = 1f;
            pause.GetComponent<CanvasGroup>().alpha = 0f;
            paused = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && lost == true)
        {
            Time.timeScale = 1f;
            Application.LoadLevel("main_menu");
        }
            if (lives == 0)
        {
            Invoke("endgame", 0f);
        }
    }

    void Spawn()
    {
        x = -7.1f + Random.value * 14f;
        Instantiate(kale, new Vector3(x, 5.83f, 0f), Quaternion.identity);
        Invoke("Spawn", 1f);
    }

    void res()
    {
        reset = false;
    }

    void endgame()
    {
        lives = -1;
        Time.timeScale = 0f;
        lose.GetComponent<CanvasGroup>().alpha = 1f;
        choice = Random.value;
        if(choice >= .75)
        {
            e1.GetComponent<CanvasGroup>().alpha = 1f;
        }
        else if (choice >= .5)
        {
            e2.GetComponent<CanvasGroup>().alpha = 1f;
        }
        else if (choice >= .25)
        {
            e3.GetComponent<CanvasGroup>().alpha = 1f;
        }
        else
        {
            e4.GetComponent<CanvasGroup>().alpha = 1f;
        }
        lost = true;
    }
}
