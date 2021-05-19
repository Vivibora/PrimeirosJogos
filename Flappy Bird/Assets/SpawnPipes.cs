using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public GameObject pipe; //referenciar os objetos que estão com os canos
    public float height; //determinar a altura máxima e minima
    public float maxTime = 1f; //tempo máximo entre as criações de canos
    private float timer = 0f; //contador de tempo


    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(pipe); //criar uma copia desse objeto na cena
        /*A posição desse conjunto de cano, vai ser a posição desse nosso spawner + novo vector3, ou seja,
         nova posição, que vai receber 0 no x, 0 noz, mas o y vai recer um valor randomico, 
        o randow.Range sorteia um valor dentro duas variaveis*/
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

    }

    // Update is called once per frame
    void Update()
    {
        //no start é o primeiro cano, aqui o restante dos canos 
        if(timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 20f); //depois de 20s os canos serão destruidos 
            timer = 0;

        }
        //aqui o maxTime é 1, entao significa que a cada 1s cria um cano
        timer += Time.deltaTime; //lendo como tempo real
    }
}
