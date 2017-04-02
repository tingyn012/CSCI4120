using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
    float speed = 6.0f;
    // Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
          transform.Rotate(new Vector3(0, speed * Time.deltaTime * 10  , 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
          transform.Rotate(new Vector3(0, -speed * Time.deltaTime * 10, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
           transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
           transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
    }
}
