using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>Pantalla de inicio: espera a que se pulse Espacio para empezar la partida.</summary>
public class GameStart : MonoBehaviour
{
    /// <summary>Indica si la partida está en marcha.</summary>
    public bool gameStarted = false;
    [SerializeField] public TMP_Text gameStartText;

    [SerializeField] private AbilityHolder player1;
    Score score;
    [SerializeField] GameObject defeatScreen;
    [SerializeField] TMP_Text finalText;

    // Start is called before the first frame update
    /// <summary>Deja la partida parada y oculta la pantalla de derrota.</summary>
    void Start()
    {
        gameStarted = false;
        defeatScreen.SetActive(false);

        player1.enabled = true;

    }

    // Update is called once per frame
    /// <summary>Enseña el mensaje de inicio y lanza <see cref="GameEvents.GameStarted"/> al pulsar Espacio.</summary>
    void Update()
    {
        if (gameStarted == false)
        {
            gameStartText.text = ("PRESS SPACE TO START");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameEvents.GameStarted.Invoke();

        }
    }

}