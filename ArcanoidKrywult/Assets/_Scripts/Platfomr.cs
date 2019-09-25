using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platfomr : MonoBehaviour
{



    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -5.4f)
            transform.position += new Vector3(-0.02f, 0f,0f);
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 5.4f)
            transform.position += new Vector3(0.02f, 0f, 0f);
    }
}
