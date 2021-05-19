using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float speed = 1f; //velocidade
    private Rigidbody2D rig; //para manipular a fisica 
    public GameObject GameOver; 
    // Start is called before the first frame update
    void Start()
    {
        //falar para a Unity pegar o RigidBody que esta como componente nesse objeto do script
        rig = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //checar quatas vezes clicamos na cena
        if (Input.GetMouseButtonDown(0)){ // 0 = botao esquerdo....1 = botao direito
            /*Adiciona velocidade ao passaro na posição para cima * speed que controla a força
             *Velocity - adiciona velocidade
             *Vector2 - tem o valor de 1 no y, então vai sempre para cima
             *Speed  - para controlar a força do pulo do passarinho*/
            
            rig.velocity = Vector2.up * speed;   

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //ativar o objetivo que até então estava desativado
        GameOver.SetActive(true);
        Time.timeScale = 0; //pausar o game
    }
}
