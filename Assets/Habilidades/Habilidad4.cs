using UnityEngine;

/// <summary>Fuerza: multiplica la fuerza del jugador durante 6 segundos.</summary>
public class Habilidad4 : Director
{
    private float currentCooldown = 0f;
    private GameStart gameStartScript;
    private AtributosJugador playerStats;
    private GameObject gameStarter;
    private GameObject player;
    [SerializeField] private ParticleSystem strengthBoostEffect;
    [SerializeField] private float strengthFactor = 2;

    /// <summary>Guarda las referencias al gestor de la partida y al jugador.</summary>
    private void Start()
    {
        // Asignar referencias en Start
        gameStarter = GameObject.FindGameObjectWithTag("Start");
        player = GameObject.FindGameObjectWithTag("Player");
        playerStats = player.GetComponent<AtributosJugador>();
        gameStartScript = gameStarter.GetComponent<GameStart>();
    }

    /// <summary>Va descontando el tiempo de espera y rellena el icono de la habilidad.</summary>
    private void FixedUpdate()
    {
        // Control del cooldown
        if (gameStartScript.gameStarted && currentCooldown > 0f)
        {
            currentCooldown -= Time.deltaTime;
            icon.fillAmount = 1 - (currentCooldown / cooldown);
        }
    }

    /// <summary>Multiplica la fuerza por <c>strengthFactor</c> y programa su vuelta a la normalidad.</summary>
    public override void Trigger()
    {
        if (gameStartScript.gameStarted && currentCooldown <= 0)
        {
            strengthBoostEffect.Play();
            playerStats.strength *= strengthFactor;
            Invoke("ResetStrengthBoost", 6f); 

            currentCooldown = cooldown;
            icon.fillAmount = 0;
        }
    }

    /// <summary>Devuelve la fuerza a su valor anterior.</summary>
    private void ResetStrengthBoost()
    {
        playerStats.strength /= strengthFactor;
    }
}
