using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptUI : MonoBehaviour
{

    static public int Life;
    static public int Score;

    public Text Lifetext;
    public Text Scoretext;


    void Start()
    {
        Life = 3;
        Score = 00000;
    }

    void Update()
    {
        Lifetext.text = "LIFES " + Score.ToString();
        Scoretext.text = "SCORE " + Life.ToString();
    }
}
