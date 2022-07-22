using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float movementSpeed = 5f;

    private Rigidbody2D rigidbody2D;
    private BoxCollider2D boxCollider2D;
    private Player player;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        Vector2 moveDirection = Player.instance.rigidbody2D.position - rigidbody2D.position;

        Vector2 lookDirection = -1 * moveDirection;
        float lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        rigidbody2D.rotation = lookAngle;

        moveDirection.Normalize();

        rigidbody2D.MovePosition(rigidbody2D.position + movementSpeed * moveDirection * Time.fixedDeltaTime);
    }

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
