using UnityEngine;
using System.Collections.Generic;

public class PlayerInventory : MonoBehaviour
{
    private HashSet<string> keys = new HashSet<string>();

    public void AddKey(string key)
    {
        keys.Add(key);
        Debug.Log($"Llave recogida: {key}");
    }

    public bool HasKey(string key)
    {
        return keys.Contains(key);
    }
    
}
