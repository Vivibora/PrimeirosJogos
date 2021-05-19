using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int Score;
    public Text scoreText;
    //chamado uma vez quando inicializa o jogo
    private void Start()
    {
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0); //0 por so tem uma cena nesse jogo
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }


}
