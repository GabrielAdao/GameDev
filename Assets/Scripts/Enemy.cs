using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //[SerializeField] Rigidbody2D rb2;
    [SerializeField] GameObject enemy;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.tag == "Shoot"){
            Debug.Log("Colidiu");
            Destroy(enemy);
        }
    }
}
