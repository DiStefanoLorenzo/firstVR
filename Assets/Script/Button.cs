using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Button : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;
    private Quaternion spawnRotation = Quaternion.identity;
    private List<GameObject> balls;

    void Start()
    {
        balls = new List<GameObject> { null };
    }

        public void OnInteract()
    {
        GetComponent<Renderer>().material.color = Color.green;
        Push(Instantiate(prefab, new Vector3(-2, 1, 20), spawnRotation));
        Pop();
    }

    // Metodo per aggiungere un elemento alla lista (Push)
    void Push(GameObject obj)
    {
        balls.Add(obj);
    }

    // Metodo per rimuovere il primo elemento della lista (Pop)
    void Pop()
    {
        if (balls.Count > 0)
        {
            GameObject firstBall = balls[0];
            Destroy(firstBall);
            balls.RemoveAt(0); // Rimuove il primo elemento
            
        }
    }
}
