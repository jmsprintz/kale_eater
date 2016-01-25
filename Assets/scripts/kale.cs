using UnityEngine;
using System.Collections;

public class kale : MonoBehaviour {
    Vector3 pos;
    public GameObject howler;

    // Use this for initialization
    void Start () {
        float x = transform.position.x;
        pos = new Vector3(x, -10f, 0f);

    }
	
    void Update()
    {
        if(control.reset == true)
        {
            Destroy(gameObject);
        }
        if(transform.position.y < -5.3f)
        {
            Instantiate(howler, transform.position, Quaternion.identity);
            control.reset = true;
            control.lives--;
            Destroy(gameObject);
        }
    }

	// Update is called once per frame
	void FixedUpdate () {
        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * 2);
    }
}
