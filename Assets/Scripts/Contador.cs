using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour
{

    private int Coins = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Coins >= 30)
        {
            Debug.Log("GAME OVER");

            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("coin"))
        {
            Coins++;
            
            Debug.Log($"Tienes {Coins} monedas.");
            Destroy(other.gameObject); // destruye moneda
        }

    }
}
