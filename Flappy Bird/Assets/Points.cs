using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public GameController controller;

    private void Start()
    {
        //vai procurar na cena objetos que tenha script do tipo gameController
        controller = FindObjectOfType<GameController>(); 
    }
    private void OnTriggerEnter2D(Collider2D colisor)
    {
        controller.Score++; //adiciona um ponto cada vez que bater nesse objeto
        controller.scoreText.text = controller.Score.ToString(); //somar um ponto na pontuação geral do jogo modificando o texto
    }
}
