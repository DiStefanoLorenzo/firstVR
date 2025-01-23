using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadMenu : MonoBehaviour, IOnButtonClick
{
    public GameObject gamemanager;
    private Score score;
    private int playerScore;

    public void Start()
    {
        Invoke("EseguiCodice", 2f);  // Esegui il metodo EseguiCodice dopo 2 secondi
    }

    // Metodo chiamato quando il bottone viene premuto
    public void OnButtonClick()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void EseguiCodice()
    {
        score = gamemanager.GetComponent<Score>();
        playerScore = score.Points;
    }

    public void SaveScore()
    {
        // Crea un'istanza di ScoreData e assegna il punteggio
        ScoreData scoreData = new ScoreData();
        scoreData.score = playerScore;

        // Serializza il dato in JSON
        string json = JsonUtility.ToJson(scoreData);

        // Salva il JSON in un file
        File.WriteAllText(Application.persistentDataPath + "/scoreData.json", json);

        Debug.Log("Punteggio salvato!");
    }

}

