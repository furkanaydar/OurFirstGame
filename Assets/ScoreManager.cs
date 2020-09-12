using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int score;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        int newPos = (int) player.transform.position.y;

        if (newPos/4 > score)
        {
            score = newPos/4;
        }
        scoreText.text = "" + score;
    }
}
