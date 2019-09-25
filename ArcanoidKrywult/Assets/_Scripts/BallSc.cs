using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSc : MonoBehaviour
{

    public GameSettings gs;

    [SerializeField]Rigidbody2D rig;

    [SerializeField]bool start;
    [SerializeField]Vector2 kierunek;


    void Start()
    {
        rig = transform.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (start)
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rig.AddForce(kierunek * 2f);
                start = false;
            }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.tag == "LightBlock")
            Destroy(col.gameObject);
        kierunek = -kierunek;
        rig.AddForce(kierunek * 2f);

        if (col.transform.tag == "killzone")
        {
            gs.lifes -= 1;
        }
    }
}
