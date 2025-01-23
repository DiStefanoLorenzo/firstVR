using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightManager : MonoBehaviour
{
    public Light pointLight; // Riferimento alla Point Light
    private Slider slider; // Riferimento allo Slider UI

    void Start()
    {
        // Ottieni il componente Slider dall'oggetto stesso
        slider = GetComponent<Slider>();

        if (slider != null && pointLight != null)
        {
            // Imposta il valore iniziale dello slider come intensità della luce
            slider.value = pointLight.intensity;

            // Aggiungi un listener per aggiornare l'intensità quando lo slider viene modificato
            slider.onValueChanged.AddListener(UpdateLightIntensity);
        }
        else
        {
            Debug.LogError("Slider o PointLight non sono stati assegnati correttamente!");
        }
    }

    // Metodo chiamato quando il valore dello slider cambia
    void UpdateLightIntensity(float value)
    {
        if (pointLight != null)
        {
            pointLight.intensity = value; // Modifica l'intensità della luce
        }
    }
}
