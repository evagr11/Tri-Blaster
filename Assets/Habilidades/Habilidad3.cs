using UnityEngine;

/// <summary>Regeneración: multiplica la curación por segundo durante 10 segundos.</summary>
public class Habilidad3 : Director
{
    private float currentCooldown = 0f;
    [SerializeField] private ParticleSystem healingParticles;
    [SerializeField] private float healingMultiplier = 0;
    private GameObject gameManager;
    private GameStart gameStartScript;
    private GameObject player;
    private AtributosJugador playerStats;

    /// <summary>Va descontando el tiempo de espera y rellena el icono de la habilidad.</summary>
    private void FixedUpdate()
    {
        if (currentCooldown > 0f)
        {
            currentCooldown -= Time.deltaTime;
            icon.fillAmount = 1 - (currentCooldown / cooldown);
        }
    }

    /// <summary>Multiplica <c>upgradeHealing</c> por <c>healingMultiplier</c> y programa su vuelta a la normalidad.</summary>
    public override void Trigger()
    {
        gameManager = GameObject.FindGameObjectWithTag("Start");
        gameStartScript = gameManager.GetComponent<GameStart>();

        if (gameStartScript.gameStarted && currentCooldown <= 0f)
        {
            healingParticles.Play();
            player = GameObject.FindGameObjectWithTag("Player");
            playerStats = player.GetComponent<AtributosJugador>();

            playerStats.upgradeHealing *= healingMultiplier;
            Invoke("StopHealingBoost", 10);

            currentCooldown = cooldown;
            icon.fillAmount = 0;
        }
    }

    /// <summary>Devuelve la curación a su valor anterior.</summary>
    private void StopHealingBoost()
    {
        playerStats.upgradeHealing /= healingMultiplier;
    }
}
