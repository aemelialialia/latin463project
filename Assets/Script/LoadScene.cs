using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("tutorial");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene("menu");
    }

    public void Cupid()
    {
        SceneManager.LoadScene("cupid");
    }

    public void Fotus()
    {
        SceneManager.LoadScene("fotus");
    }

    public void StartDate()
    {
        SceneManager.LoadScene("ApolloTinder");
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerMovement>())
        {
            int currentScene = SceneManager.GetActiveScene().buildIndex;
            if (currentScene < 5)
            {
                SceneManager.LoadScene(currentScene + 1);
            } else
            {
                Application.Quit();
            }
        }
    }
}
