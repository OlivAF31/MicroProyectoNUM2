using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public string keyName; // Nombre de la llave (ej. "llave_1")

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log($"Llave recogida: {keyName}");
            other.GetComponent<PlayerInventory>().AddKey(keyName);
            Destroy(gameObject); // Destruir la llave tras recogerla
        }
    }

}
