using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Proyectil que avanza en línea recta y daña a los enemigos.</summary>
public class Proyectil : MonoBehaviour
{
    /// <summary>Dirección del disparo; la pone <see cref="Habilidad1"/>.</summary>
    [SerializeField] public float damage;  
    [SerializeField] public float speed;   
    [HideInInspector] public Vector3 direction;  

    private Rigidbody2D rb;

    /// <summary>Guarda el <c>Rigidbody2D</c>.</summary>
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    /// <summary>Mueve el proyectil y lo destruye al salir de la pantalla.</summary>
    void Update()
    {
        if (direction != Vector3.zero && rb != null)
        {
            rb.velocity = direction * speed;
        }

        if (transform.position.x >= 12 || transform.position.x <= -12 || transform.position.y >= 8 || transform.position.y <= -8)
        {
            Destroy(gameObject);
        }
    }

    /// <summary>Al chocar con un enemigo le quita <c>damage</c> por la fuerza del jugador y se destruye.</summary>
    /// <param name="collision">Datos del choque.</param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            HealthEnemy enemyHealth = collision.gameObject.GetComponent<HealthEnemy>();
            if (enemyHealth != null)
            {
                GameObject player = GameObject.FindGameObjectWithTag("Player");
                AtributosJugador playerAttributes = player.GetComponent<AtributosJugador>();

                enemyHealth.currentHealth -= damage * playerAttributes.strength;
            }
            Destroy(gameObject); 
        }
    }
}
