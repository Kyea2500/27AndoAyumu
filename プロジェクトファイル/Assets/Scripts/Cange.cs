using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cange : MonoBehaviour
{
    public void Onclick1()
    {
        SceneManager.LoadScene("Game");
    }
    public void Onclick2()
    {
        SceneManager.LoadScene("GameOver");
    }
}
