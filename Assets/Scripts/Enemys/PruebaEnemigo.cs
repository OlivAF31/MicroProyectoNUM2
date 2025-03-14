using UnityEngine;
using System.Collections;

public class PruebaEnemigo : MonoBehaviour
{
    public int damage = 1; // Daño que causa al tocar al jugador
    private bool hasDealtDamage = false; // Controla si ya hizo daño

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && !hasDealtDamage)
        {
            Health playerHealth = collision.gameObject.GetComponent<Health>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
                Debug.Log("¡El enemigo ha hecho daño!");
                hasDealtDamage = true; // Marca que ya hizo daño
                StartCoroutine(ResetDamage()); // Reinicia el daño después de un tiempo
            }
        }
    }

    IEnumerator ResetDamage()
    {
        yield return new WaitForSeconds(1f); // Espera 1 segundo antes de permitir otro golpe
        hasDealtDamage = false;
    }
}
