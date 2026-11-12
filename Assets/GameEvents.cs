using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

/// <summary>Eventos estáticos del juego.</summary>
public class GameEvents : MonoBehaviour
{
    public class RotationMacroEvent : UnityEvent<int[], float[]> { };
    /// <summary>Se lanza cuando el jugador se queda sin vida.</summary>
    public static UnityEvent PlayerDied = new UnityEvent();
    /// <summary>Se lanza al matar a un enemigo.</summary>
    public static UnityEvent EnemyDied = new UnityEvent();
    /// <summary>Se lanza al pulsar Espacio para empezar.</summary>
    public static UnityEvent GameStarted = new UnityEvent();
}
