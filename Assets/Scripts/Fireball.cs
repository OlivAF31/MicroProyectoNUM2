using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed = 10f;
    public float lifetime = 5f;

    private Vector3 moveDirection;

    public void SetDirection(Vector2 direction)
    {
        // Convertir la dirección 2D (X, Y) a una dirección 3D (X, Z)
        moveDirection = new Vector3(direction.x, 0, direction.y).normalized;
        Destroy(gameObject, lifetime); // Destruir tras X segundos
    }

    void Update()
    {
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
    }
}
