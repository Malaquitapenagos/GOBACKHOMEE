using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    public GameObject pauseMenu;

    // Start is called before the first frame update
    public void pausa()
    {
        Debug.Log("pause");
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    public void continuar()
    {
        Debug.Log("player");
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
