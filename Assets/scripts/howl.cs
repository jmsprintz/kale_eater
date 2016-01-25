using UnityEngine;
using System.Collections;

public class howl : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("end", 4f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void end()
    {
        Destroy(gameObject);
    }
}
