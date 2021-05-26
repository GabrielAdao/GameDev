using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletConfig : MonoBehaviour
{
    [SerializeField] GameObject Bullet;
    [SerializeField] float projectileSpeed = 20f;
    [SerializeField ]Transform player;
    [SerializeField ]Transform target;
    public Vector2 speed;
    public float fireRate = 3000f;

    private float shootingTime;


    void Update()
    {
        Fire();
    }

    void Fire()
    {
        if (Time.time > shootingTime)
        {
            shootingTime = Time.time + fireRate / 1000;
            Vector2 myPos = new Vector2(player.position.x, player.position.y);
            GameObject projectile = Instantiate(Bullet, myPos, Quaternion.identity);
            Vector2 enemyDirection = myPos + (Vector2)target.position;
            projectile.GetComponent<Rigidbody2D>().velocity = enemyDirection * projectileSpeed;

            //Collision2D collision = shoot.GetComponent<Collision2D>();
            //OnCollisionEnter2D(collision);
        }
    }
}
