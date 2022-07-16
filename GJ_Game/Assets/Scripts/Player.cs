using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;

    public float movementSpeed = 5f;
    public Camera camera;

    Vector2 movement;
    Vector2 mousePosition;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal"); // `A` or `D` key
        movement.y = Input.GetAxisRaw("Vertical"); // `W` or `S` key

        mousePosition = camera.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        // rigidbody2D.AddForce(new Vector2(0f, 0.3f), ForceMode2D.Impulse);
        rigidbody2D.MovePosition(rigidbody2D.position + movementSpeed * movement * Time.fixedDeltaTime);

        Vector2 lookDirection = mousePosition - rigidbody2D.position;
        float lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        rigidbody2D.rotation = lookAngle;
    }
}
