using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject gamemanager;
    private Score score;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("EseguiCodice", 2f);  // Esegui il metodo EseguiCodice dopo 2 secondi
    }

    public void EseguiCodice()
    {
        score = gamemanager.GetComponent<Score>();
    }



    void OnTriggerEnter(Collider other)
    {
 
            score.Hit(2);
     
    }

}
