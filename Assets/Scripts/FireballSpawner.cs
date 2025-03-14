using UnityEngine;

public class FireballSpawner : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 direction; // Dirección en la que se moverá la bola de fuego
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = direction * speed; // Aplicar velocidad en la dirección correcta
    }

    public void SetDirection(Vector3 newDirection)
    {
        direction = newDirection.normalized; // Normalizar para que tenga magnitud 1
    }
}
