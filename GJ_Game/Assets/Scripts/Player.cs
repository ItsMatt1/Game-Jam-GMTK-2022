using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static Player instance;

    public Rigidbody2D rigidbody2D;

    public float movementSpeed = 5f;
    public Camera camera;

    Vector2 movement;
    Vector2 mousePosition;


    public int maxHealth = 4;
    public int currentHealth;

    public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        rigidbody2D = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        getPlayerInput();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    void FixedUpdate()
    {
        movePlayer();
    }

    void movePlayer()
    {
        // rigidbody2D.AddForce(new Vector2(0f, 0.3f), ForceMode2D.Impulse);
        rigidbody2D.MovePosition(rigidbody2D.position + movementSpeed * movement * Time.fixedDeltaTime);

        Vector2 lookDirection = mousePosition - rigidbody2D.position;
        float lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        rigidbody2D.rotation = lookAngle;
    }

    void getPlayerInput()
    {
        movement.x = Input.GetAxisRaw("Horizontal"); // `A` or `D` key
        movement.y = Input.GetAxisRaw("Vertical"); // `W` or `S` key

        mousePosition = camera.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            TakeDamage(1);

            if (currentHealth <= 0)
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
