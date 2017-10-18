using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sushi : MonoBehaviour
{

    public int puntaje = 10;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            MyGameManager.instance.AddScore(puntaje);
            Destroy(gameObject);
        }
    }
}
