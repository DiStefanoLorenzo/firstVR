using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Score : MonoBehaviour
{
    private int _points = 0;

    public GameObject monitor1;
    public GameObject monitor2;

    private ScoreUI scoreUI1;
    private ScoreUI scoreUI2;

    public void Start()
    {
        Invoke("EseguiCodice", 2f);  // Esegui il metodo EseguiCodice dopo 2 secondi
    }

    public void EseguiCodice()
    {
        scoreUI1 = monitor1.GetComponent<ScoreUI>();
        scoreUI2 = monitor2.GetComponent<ScoreUI>();

        scoreUI1.setScore(0);
        scoreUI2.setScore(0);
    }


    public void Hit(int points)
    {
        if (points >= 1 && points <= 3)
        {
            _points += points;
            scoreUI1.setScore(_points);
            scoreUI2.setScore(_points);
        }
    }

    public int Points { get { return _points; } }
}
