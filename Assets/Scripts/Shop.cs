using UnityEngine;

public class Shop : MonoBehaviour
{
    public int speedPrice = 50;
    public int healthPrice = 30;
    public float speedIncrease = 1f;
    public int healthIncrease = 1;

    private PlayerMoney playerMoney;
    private PlayerController playerController;
    private Health playerHealth;

    void Start()
    {
        playerMoney = FindObjectOfType<PlayerMoney>();
        playerController = FindObjectOfType<PlayerController>();
        playerHealth = FindObjectOfType<Health>();
    }

    public void BuySpeed()
    {
         Debug.Log("Botón presionado");
    if (playerMoney.SpendCoins(speedPrice))
    {
        playerController.IncreaseSpeed(speedIncrease);
        Debug.Log("Speed comprado! Nueva velocidad: " + playerController.speed);
    }
    else
    {
        Debug.Log("No tienes suficientes monedas!");
    }
    }

    public void BuyHealth()
    {
        if (playerMoney.SpendCoins(healthPrice))
        {
            playerHealth.Heal(healthIncrease);
            Debug.Log("Salud comprada! Vida actual: " + playerHealth.health);
        }
        else
        {
            Debug.Log("No tienes suficientes monedas!");
        }
    }
}
