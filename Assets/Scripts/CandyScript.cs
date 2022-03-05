using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            // Increment Score
            GameManager.instance.IncrementScore();
            Destroy(gameObject);
        }

        else if (collider.gameObject.tag == "Boundary")
        {
            // Decrease Lives
            GameManager.instance.DecreaseLife();
            Destroy(gameObject);
        }
    }

}
