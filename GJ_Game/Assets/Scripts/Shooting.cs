using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    // public Dice dice;

    public float bulletForce = 20f;

    private Animator animator;

    private float timeStamp = 0;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (timeStamp <= Time.time)
        {
            animator.SetBool("IsShooting", false);

            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
                animator.SetBool("IsShooting", true);
                timeStamp = Time.time + 0.2f;
            }
        }




        // if (Input.GetButtonDown("Fire1") && Dice.instance.finalSide == 2)
        // {
        //     Shoot();
        //     Shoot();
        // }

        // if (Input.GetButtonDown("Fire1") && Dice.instance.finalSide == 3)
        // {
        //     Shoot();
        //     Shoot();
        //     Shoot();
        // }

        // if (Input.GetButtonDown("Fire1") && Dice.instance.finalSide == 4)
        // {
        //     Shoot();
        //     Shoot();
        //     Shoot();
        //     Shoot();
        // }

        // if (Input.GetButtonDown("Fire1") && Dice.instance.finalSide == 5)
        // {
        //     Shoot();
        //     Shoot();
        //     Shoot();
        //     Shoot();
        //     Shoot();
        // }

        // if (Input.GetButtonDown("Fire1") && Dice.instance.finalSide == 6)
        // {
        //     Shoot();
        //     Shoot();
        //     Shoot();
        //     Shoot();
        //     Shoot();
        //     Shoot();
        // }
    }
    void Shoot()
    {
        AudioManager.instance.Play("Shot");

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rigidbody2D = bullet.GetComponent<Rigidbody2D>();
        rigidbody2D.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
