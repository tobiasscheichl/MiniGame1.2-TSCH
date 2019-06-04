﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectible : MonoBehaviour
{
    private int score= 0;
    public ScoreData myData;
    public TextMeshProUGUI pointsScore;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggerevent" + collision.gameObject.name);

        if (collision.gameObject.name == "Player")
        {
            score += 5;
            Debug.Log("score+" + score);
            myData.myScore = score;
            //pointsScore.text = score.ToString();
        }
        else if (collision.gameObject.name == "GedachteLinie")
        {
            score -= 10;
            Debug.Log("score-" + score);
            myData.myScore = score;
            //pointsScore.text = score.ToString();
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("CollisionEvent");
    }
}
