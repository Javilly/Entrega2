using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piso : MonoBehaviour {

    public int puntajePlataforma;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            MyGameManager.instance.AddScore(puntajePlataforma);
        }
    }
}
