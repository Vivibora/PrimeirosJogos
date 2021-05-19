using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        /*uma nova posição para esse objeto a cada frame
         transform.position = a posição desse objeto
         Vector3.left = ele sempre vai para esquerda
         speed = para aumentar a velocidade desse movimento
         deltaTime para o movimento ficar mais suave
         */
        transform.position += Vector3.left * speed * Time.deltaTime;
        
    }
}
