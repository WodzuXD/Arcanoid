using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{

    public int lifes;
    public int score;

    public Text tekst;
    public Image lifesImage1;
    public Image lifesImage2;
    public Image lifesImage3;

    void Start()
    {
        
    }

    void Update()
    {
        tekst.text = score.ToString();
        if (lifes >= 1)
        {
            lifesImage1.enabled = true;
            if (lifes >= 2)
            {
                lifesImage2.enabled = true;
                if (lifes >= 3)
                {
                    lifesImage3.enabled = true;
                }
                else
                    lifesImage3.enabled = false;
            }
            else
                lifesImage2.enabled = false;
        }
        else
            lifesImage1.enabled = false;
    }
}
