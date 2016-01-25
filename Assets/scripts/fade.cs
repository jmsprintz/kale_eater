using UnityEngine;
using System.Collections;

public class fade : MonoBehaviour {
    float level = 1;
    float less = .003f;
	// Use this for initialization
	void Start () {
        level = 1;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (level < .6f) less = .009f;
        level = level - less;
        gameObject.GetComponent<CanvasGroup>().alpha = level;
    }
}
