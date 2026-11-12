using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Clase base de las habilidades: nombre, icono y tiempo de espera. Cada habilidad
/// (<see cref="Habilidad1"/> a <see cref="Habilidad4"/>) implementa <see cref="Trigger"/>.
/// </summary>
public abstract class Director : MonoBehaviour
{
    [SerializeField] protected string abilityName;
    [SerializeField] protected Image icon;
    [SerializeField] protected float cooldown;

    /// <summary>Usa la habilidad.</summary>
    public abstract void Trigger();
}
