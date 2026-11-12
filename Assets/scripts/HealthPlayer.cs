using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>Vida del jugador: color según la vida, daño al chocar con enemigos y pantalla de derrota.</summary>
public class HealthPlayer : MonoBehaviour
{
    [SerializeField] private ParticleSystem damageParticles;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Gradient healthColor;
    public ParticleSystem healthParticles;
    private AtributosJugador playerAttributesScript;
    private HealthEnemy enemyMovement;

    [SerializeField] private AbilityHolder player;
    Score score;
    [SerializeField] GameObject defeatScreen;
    [SerializeField] TMP_Text finalText;

    /// <summary>Empieza con la vida al máximo.</summary>
    void Start()
    {
        score = FindObjectOfType<Score>();
        playerAttributesScript = GetComponent<AtributosJugador>();
        playerAttributesScript.health = playerAttributesScript.maxHealth;
        UpdateHealthColor();
    }

    /// <summary>
    /// Reinicia con R, no deja pasar la vida del máximo y, si llega a 0, lanza
    /// <see cref="GameEvents.PlayerDied"/> y enseña la pantalla de derrota con los puntos.
    /// </summary>
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }

        if (playerAttributesScript.health > playerAttributesScript.maxHealth)
        {
            playerAttributesScript.health = playerAttributesScript.maxHealth;
        }

        UpdateHealthColor();

        if (playerAttributesScript.health <= 0)
        {
            GameEvents.PlayerDied.Invoke();
            defeatScreen.SetActive(true);

            player.enabled = false;

            finalText.text = $"You got {score.score} points."; 
        }
    }

    /// <summary>Pinta al jugador con el color del degradado que corresponde a su vida.</summary>
    private void UpdateHealthColor()
    {
        spriteRenderer.color = healthColor.Evaluate(1f * playerAttributesScript.health / playerAttributesScript.maxHealth);
    }

    /// <summary>Vuelve a cargar la escena.</summary>
    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    /// <summary>Al chocar con un enemigo, resta su daño y enseña las partículas.</summary>
    /// <param name="collision">Datos del choque.</param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            enemyMovement = collision.gameObject.GetComponent<HealthEnemy>();
            playerAttributesScript.health -= enemyMovement.attackDamage;
            damageParticles.Play();
        }
    }
}
