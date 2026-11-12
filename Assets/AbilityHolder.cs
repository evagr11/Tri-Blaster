using UnityEngine;

/// <summary>
/// Habilidades del jugador: se eligen con las teclas 1 a 5 y se usan con el clic izquierdo.
/// </summary>
public class AbilityHolder : MonoBehaviour
{
    /// <summary>Si es <c>false</c>, el clic no lanza ninguna habilidad.</summary>
    public bool habilitiesActive = true;
    /// <summary>Posición de la habilidad elegida en la lista.</summary>
    [SerializeField] private Director[] availableAbilities;
    public int currentAbilityIndex;

    /// <summary>Lanza la habilidad elegida al hacer clic y cambia de habilidad con las teclas 1 a 5.</summary>
    private void Update()
    {
        if (availableAbilities.Length > 0 && currentAbilityIndex >= 0 && currentAbilityIndex < availableAbilities.Length)
        {
            if (habilitiesActive)
            {
                if (Input.GetMouseButtonDown(0)) 
                {
                    availableAbilities[currentAbilityIndex].Trigger();
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentAbilityIndex = 0; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentAbilityIndex = 1; }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { currentAbilityIndex = 2; }
        if (Input.GetKeyDown(KeyCode.Alpha4)) { currentAbilityIndex = 3; }
        if (Input.GetKeyDown(KeyCode.Alpha5)) { currentAbilityIndex = 4; }

        if (currentAbilityIndex < 0)
        {
            currentAbilityIndex = 0;  
        }
        else if (currentAbilityIndex >= availableAbilities.Length)
        {
            currentAbilityIndex = availableAbilities.Length - 1;  
        }
    }
}
