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

    public void OnApplicationQuit()
    {
        //quit
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

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerMovement>())
        {
            SceneManager.LoadScene("apollo");
        }
    }
}
