using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // public Transform player;
    public float movementSpeed = 5f;

    private Rigidbody2D rigidbody2D;
    private BoxCollider2D boxCollider2D;
    private Player player;
    // private Vector2 playerPosition;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Vector2 playerPosition = player.rigidbody2D.position;
        Vector2 moveDirection = Player.instance.rigidbody2D.position - rigidbody2D.position;

        Vector2 lookDirection = -1 * moveDirection;
        // lookDirection.x = -lookDirection.x;
        // lookDirection.y = -lookDirection.y;
        float lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        rigidbody2D.rotation = lookAngle;

        moveDirection.Normalize();
        // lookDirection.x = -lookDirection.x;
        // lookDirection.y = -lookDirection.y;
        rigidbody2D.MovePosition(rigidbody2D.position + movementSpeed * moveDirection * Time.fixedDeltaTime);
    }

    void FixedUpdate()
    {}

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Object.Destroy(gameObject);
            Object.Destroy(other.gameObject);
            Score.instance.bodyCount++;
        }
    }
}
