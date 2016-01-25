using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour
{
    float speed = 9f;
    Vector3 move;
    int direction;
    // Use this for initialization
    void Start()
    {
        direction = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += move * speed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "kale")
        {
            control.score++;
            Destroy(coll.gameObject);
        }
    }

    void Update()
    {
        if(transform.position.x < -7.83)
        {
            transform.position = new Vector3(7.8f, transform.position.y, 0f);
        }
        if(transform.position.x > 7.83)
        {
            transform.position = new Vector3(-7.8f, transform.position.y, 0f);
        }
        if (move.x > 0) direction = 1;
        else if (move.x < 0) direction = -1;

        if(direction == 1)
        {
            transform.localEulerAngles = new Vector3(0f, 0f, 0f);
        }
        else if(direction == -1)
        {
            transform.localEulerAngles = new Vector3(0f, 180f, 0f);
        }
    }
}
