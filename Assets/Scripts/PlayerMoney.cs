using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    public int coins = 0;

    public bool SpendCoins(int amount)
    {
        if (coins >= amount)
        {
            coins -= amount;
            return true;
        }
        return false;
    }

    public void AddCoins(int amount) 
    {
        coins += amount;
    }
}
