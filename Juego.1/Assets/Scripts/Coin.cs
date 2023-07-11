using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Moneda");

        gameObject.SetActive(false);
        //Destroy(gameObject);

        if (SceneManager.GetActiveScene().name == "Escena.1")
        {
            SceneManager.LoadScene("Escena.2");

        }
        else
        {
            SceneManager.LoadScene("Escena.3");

        }

    }
}
