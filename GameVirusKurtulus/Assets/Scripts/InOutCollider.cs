using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InOutCollider : MonoBehaviour
{
    public GameObject button;
    private void Start()
    {
        button.SetActive(false);
    }
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        button.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        button.SetActive(false);
    }
    // Hangi Collider a girince button acilcaksa ona atancak collider a atancak
    // Button'da navigation none olcak yoksa herhangi atanmis tusta button calisiyor
    // Button kodu kendi uzerine yaz,lca
}
