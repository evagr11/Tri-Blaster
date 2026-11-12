using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>Reacciona al inicio de la partida y a la muerte del jugador.</summary>
public class Event : MonoBehaviour
{
    private GameStart startScript;
    private AtributosJugador playerAttributesScript;
    private GameObject player;
    private GameObject enemy;

    /// <summary>Busca el jugador, el enemigo y el gestor de la partida y se suscribe a los eventos.</summary>
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        GameObject gameStart = GameObject.FindGameObjectWithTag("Start");

        startScript = gameStart.GetComponent<GameStart>();
        playerAttributesScript = player.GetComponent<AtributosJugador>();

        GameEvents.PlayerDied.AddListener(PlayerDeath);
        GameEvents.GameStarted.AddListener(StartingGame);
    }

    /// <summary>Para la partida y enseña «Pulsa R para reiniciar».</summary>
    private void PlayerDeath()
    {
        startScript.gameStarted = false;
        startScript.gameStartText.text = "Pulsa R para reiniciar";

    }

    /// <summary>Empieza la partida: vida al máximo, jugador en el centro y sin el enemigo inicial.</summary>
    private void StartingGame()
    {
        startScript.gameStarted = true;
        playerAttributesScript.health = playerAttributesScript.maxHealth;
        Destroy(enemy);
        player.transform.position = Vector2.zero;
        startScript.gameStartText.text = "";

    }
}
