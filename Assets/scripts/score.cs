using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {
    Text number;
	// Use this for initialization
	void Start () {
        number = gameObject.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        number.text = "Kale Eaten: " + control.score;
	}
}
