using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletConfig : MonoBehaviour
{
    [SerializeField] GameObject Bullet;
    [SerializeField] float projectileSpeed = 10f;

    public Vector2 speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
    }

    void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject shoot = Instantiate(Bullet, transform.position, Quaternion.identity) as GameObject;
            shoot.GetComponent<Rigidbody2D>().velocity = new Vector2(0, projectileSpeed);
            
        }
    }
}
