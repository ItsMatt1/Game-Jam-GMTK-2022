using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerWall : MonoBehaviour
{
    // public Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        // rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

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
