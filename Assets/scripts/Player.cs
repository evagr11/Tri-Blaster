using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Gira al jugador para que mire hacia el ratón.</summary>
public class Player : MonoBehaviour
{
    private GameObject gameStart;
    private GameStart startScript;

    /// <summary>Gira al jugador mientras la partida está en marcha.</summary>
    void Update()
    {
        gameStart = GameObject.FindGameObjectWithTag("Start");
        startScript = gameStart.GetComponent<GameStart>();

        if (startScript.gameStarted)
        {
            HandleRotation();
        }
    }

    /// <summary>Calcula el ángulo entre el jugador y el ratón y lo aplica a la rotación.</summary>
    private void HandleRotation()
    {
        Vector3 mousePosition = Input.mousePosition;

        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition.z = 0;

        Vector3 direction = mousePosition - transform.position;

        float angle = Vector3.SignedAngle(Vector3.up, direction, Vector3.forward);

        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
