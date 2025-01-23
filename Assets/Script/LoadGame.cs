using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour, IOnButtonClick
{

    // Metodo chiamato quando il bottone viene premuto
    public void OnButtonClick()
    {
        SceneManager.LoadScene("BasicScene");
    }
}

