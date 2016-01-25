using UnityEngine;
using System.Collections;

public class dog2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (control.lives < 2) Destroy(gameObject);
    }
}
