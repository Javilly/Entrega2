using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    bool release = false;
    Vector3 target;
    public int vidas = 3;

    void Update()
    {
        if(vidas == 0)
        {
            MyGameManager.instance.ShowScore();
            transform.Translate(0, 0, 0);
            release = false;
            vidas = 3;
            MyGameManager.instance.Restart();
        }
        if (!release)
        {
            GetComponent<Rigidbody2D>().gravityScale = 0;
            target = Input.mousePosition;
            target = Camera.main.ScreenToWorldPoint(target);
            target.y = transform.position.y;
            target.z = Mathf.Clamp(transform.position.z, 0, 0);
            transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime);
            target.x = Mathf.Clamp(transform.position.x, -2, 2);

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                release = true;
                GetComponent<Rigidbody2D>().gravityScale = 1;
            }
        }

    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Finish")
        {
            Debug.Log("Bota");
            transform.Translate(0, 0, 0);
            release = false;
            vidas -= 1;
        }
    }
}
