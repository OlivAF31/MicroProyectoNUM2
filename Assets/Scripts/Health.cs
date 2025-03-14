using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Update()
    {
        UpdateHearts();
    }

    public void TakeDamage(int amount)
    {
        health -= amount;

        if (health < 0)
        {
            health = 0; // Evita que la salud sea negativa
        }

        UpdateHearts();
    }

    public void Heal(int amount) 
    {
        health += amount;
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }
        UpdateHearts();
    }


    void UpdateHearts()
    {
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            hearts[i].enabled = (i < numOfHearts);
        }
    }
}
