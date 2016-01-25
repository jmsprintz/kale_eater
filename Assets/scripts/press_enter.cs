using UnityEngine;
using System.Collections;

public class press_enter : MonoBehaviour {
    public GameObject text;
	// Use this for initialization
	void Start () {
        Invoke("flash", .7f);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Application.LoadLevel("scene_0");
        }
    }

    void flash()
    {
        text.GetComponent<CanvasGroup>().alpha = 0f;
        Invoke("unflash", .7f);
    }

    void unflash()
    {
        text.GetComponent<CanvasGroup>().alpha = 1f;
        Invoke("flash", .7f);
    }
}
