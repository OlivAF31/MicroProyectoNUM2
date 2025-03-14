using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject fireballPrefab; // El prefab de la bola de fuego
    public Transform firePoint; // El punto desde donde sale la bola
    public float fireballSpeed = 10f;
    public float firePointOffset = 1f; // Distancia desde el personaje

    private Vector2 fireDirection = Vector2.right; // Dirección inicial (derecha)

    void Update()
    {
        // Actualizar dirección y mover el FirePoint
        if (Input.GetKey(KeyCode.UpArrow))
        {
            fireDirection = Vector2.up;
            firePoint.localPosition = new Vector2(0, firePointOffset);
            firePoint.localScale = new Vector3(1, 1, 1); // Asegura que no se invierta el FirePoint
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            fireDirection = Vector2.down;
            firePoint.localPosition = new Vector2(0, firePointOffset);
            firePoint.localScale = new Vector3(1, -1, 1); // Invertir el FirePoint hacia abajo (mantener la misma posición)
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            fireDirection = Vector2.left;
            firePoint.localPosition = new Vector2(-firePointOffset, 0);
            firePoint.localScale = new Vector3(1, 1, 1); // Asegura que no se invierta el FirePoint
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            fireDirection = Vector2.right;
            firePoint.localPosition = new Vector2(firePointOffset, 0);
            firePoint.localScale = new Vector3(1, 1, 1); // Asegura que no se invierta el FirePoint
        }

        // Lanzar bola de fuego con espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject fireball = Instantiate(fireballPrefab, firePoint.position, Quaternion.identity);
        fireball.GetComponent<Fireball>().SetDirection(fireDirection);
    }
}
