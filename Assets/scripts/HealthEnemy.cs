using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Vida del enemigo, que cambia de color según la que le queda.</summary>
public class HealthEnemy : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Gradient healthGradient;
    public float currentHealth;
    /// <summary>Vida que quita al jugador al chocar con él.</summary>
    [SerializeField] private float maxHealthValue;
    public float attackDamage = 2;

    /// <summary>Empieza con la vida al máximo.</summary>
    private void Start()
    {
        currentHealth = maxHealthValue;
        UpdateHealthIndicator();
    }

    /// <summary>Actualiza el color y, si se queda sin vida, se destruye y avisa con <see cref="GameEvents.EnemyDied"/>.</summary>
    private void Update()
    {
        UpdateHealthIndicator();

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            TriggerDeathSequence();
        }
    }

    /// <summary>Pinta el enemigo con el color del degradado que corresponde a su vida.</summary>
    private void UpdateHealthIndicator()
    {
        spriteRenderer.color = healthGradient.Evaluate(currentHealth / maxHealthValue);
    }

    

    /// <summary>Lanza el evento de enemigo muerto.</summary>
    private void TriggerDeathSequence()
    {
        GameEvents.EnemyDied.Invoke();
    }
}