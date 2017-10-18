using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Finish")
        {
            transform.Translate(new Vector3(0, 0, 0));
        }
    }

}
