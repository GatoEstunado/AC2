using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passagem : MonoBehaviour
{
    public string Cena;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.LoadScene(Cena);
        }
    }
}
