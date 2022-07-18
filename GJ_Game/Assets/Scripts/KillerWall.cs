using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerWall : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
            return;
        else if (other.gameObject.tag == "Bullet")
            Object.Destroy(other.gameObject);

    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
            return;
        else if (other.gameObject.tag == "Bullet")
            Object.Destroy(other.gameObject);
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
            return;
        else if (other.gameObject.tag == "Bullet")
            Object.Destroy(other.gameObject);
    }
}
