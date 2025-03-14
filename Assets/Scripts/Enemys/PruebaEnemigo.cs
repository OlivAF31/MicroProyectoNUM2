using UnityEngine;
using System.Collections;

public class PruebaEnemigo : MonoBehaviour
{
    public int damage = 1; // Da�o que causa al tocar al jugador
    private bool hasDealtDamage = false; // Controla si ya hizo da�o

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && !hasDealtDamage)
        {
            Health playerHealth = collision.gameObject.GetComponent<Health>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
                Debug.Log("�El enemigo ha hecho da�o!");
                hasDealtDamage = true; // Marca que ya hizo da�o
                StartCoroutine(ResetDamage()); // Reinicia el da�o despu�s de un tiempo
            }
        }
    }

    IEnumerator ResetDamage()
    {
        yield return new WaitForSeconds(1f); // Espera 1 segundo antes de permitir otro golpe
        hasDealtDamage = false;
    }
}
