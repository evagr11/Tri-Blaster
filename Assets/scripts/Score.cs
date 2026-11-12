using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>Puntuación: un punto por enemigo muerto.</summary>
public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreCounter;
    public int score = 0;

    /// <summary>Pone la puntuación a 0 y se suscribe a <see cref="GameEvents.EnemyDied"/>.</summary>
    private void Start()
    {
        score = 0;
        UpdateScoreText();
        GameEvents.EnemyDied.AddListener(EnemyDying);
    }

    /// <summary>Escribe la puntuación en pantalla.</summary>
    public void UpdateScoreText()
    {
        scoreCounter.text = "Score: " + score;
    }

    /// <summary>Suma un punto.</summary>
    public void EnemyDying()
    {
        score++;
        UpdateScoreText();
    }
}
