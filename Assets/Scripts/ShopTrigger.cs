using UnityEngine;

public class ShopTrigger : MonoBehaviour
{
    public GameObject shopPanel; // UI de la tienda
    private bool isNearShop = false; // Saber si el jugador está cerca

    void Start()
    {
        shopPanel.SetActive(false); // Asegurar que la tienda empieza oculta
    }

    void Update()
    {
        if (isNearShop && Input.GetKeyDown(KeyCode.E)) // Si el jugador está cerca y presiona "E"
        {
            shopPanel.SetActive(!shopPanel.activeSelf); // Alternar el estado del panel
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Si el jugador entra en la zona
        {
            isNearShop = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Si el jugador se aleja
        {
            isNearShop = false;
            shopPanel.SetActive(false); // Cierra la tienda si el jugador se va
        }
    }
}
