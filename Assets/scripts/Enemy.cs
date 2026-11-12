using UnityEngine;

/// <summary>Enemigo que va hacia el jugador; si el jugador ha muerto, se aleja.</summary>
public class Enemy : MonoBehaviour
{
    private Transform targetPosition;
    private GameObject target;
    private Vector3 moveDirection;
    private AtributosJugador targetAttributes;
    [SerializeField] private float moveSpeed;

    /// <summary>Mueve el enemigo hacia el jugador, o en sentido contrario si el jugador no tiene vida.</summary>
    private void Update()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        if (target == null) return;

        targetPosition = target.transform;
        moveDirection = (targetPosition.position - transform.position).normalized;
        targetAttributes = target.GetComponent<AtributosJugador>();

        if (targetAttributes.health > 0)
        {
            transform.position += moveDirection * moveSpeed * Time.deltaTime;
        }
        else
        {
            transform.position -= moveDirection * moveSpeed * Time.deltaTime;
        }
    }

    /// <summary>Se destruye al chocar con el jugador.</summary>
    /// <param name="collision">Datos del choque.</param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
