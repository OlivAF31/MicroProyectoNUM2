using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ScenePortal : MonoBehaviour
{
    [SerializeField] private string sceneToLoad; // Nombre de la escena a cargar
    [SerializeField] private Vector3 spawnPosition; // Posición donde aparecerá el jugador

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(LoadScene());
        }
    }

    private IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(1f); // Retraso antes de cambiar de escena
        SceneManager.LoadScene(sceneToLoad);
        yield return new WaitForSeconds(0.1f);

        // Encontrar al jugador en la nueva escena y moverlo a la posición deseada
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            player.transform.position = spawnPosition;
        }
    }
}
