using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float moveLimitX;
    [SerializeField] private float moveLimitY;
    [SerializeField] private float moveVel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && transform.position.x > -moveLimitX)
        {
            transform.position = new Vector2(transform.position.x - moveVel, transform.position.y);
        }

        if (Input.GetKey(KeyCode.A) && transform.position.x < moveLimitX)
        {
            transform.position = new Vector2(transform.position.x + moveVel, transform.position.y);
        }

        if (Input.GetKey(KeyCode.S) && transform.position.y < moveLimitY)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + moveVel);
        }

        if (Input.GetKey(KeyCode.W) && transform.position.y > -moveLimitY)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - moveVel);
        }
    }
}
