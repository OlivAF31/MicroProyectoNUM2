using UnityEngine;

public class DungeonPortal : MonoBehaviour
{
    public Transform destination; // A dónde lleva esta puerta
    public string requiredKey;     // Llave necesaria para abrir la puerta
    private PlayerInventory playerInventory;

    private void Start()
    {
        playerInventory = FindObjectOfType<PlayerInventory>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (playerInventory.HasKey(requiredKey))
            {
                other.transform.position = destination.position; // Mueve al jugador
                Debug.Log($"Has pasado a {destination.name}.");
            }
            else
            {
                Debug.Log($"¡Necesitas la {requiredKey} para abrir esta puerta!");
            }
        }
    }
}
