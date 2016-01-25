using UnityEngine;
using System.Collections;

public class dog1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (control.lives < 1) Destroy(gameObject);
    }
}
