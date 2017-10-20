using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class moveLixo : MonoBehaviour
{

    public float      speed;
    public float      x;
    public GameObject Lixo;

    void Start()
    {
        Lixo = GameObject.Find("Lixo") as GameObject;
    }

    public void moveDireita()
    {
      //  Debug.Log("direita");
        x = transform.position.x;
        x += speed * Time.deltaTime;
        while (x >= 6.25f)
        {
           x=6.249f;
        }
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    

    }

    public void moveEsquerda()
    {
       // Debug.Log("Esquerda");
        x = transform.position.x;
        x -= speed * Time.deltaTime;
        while (x <= -1.25f)
        {
            x = -1.249f;
        }
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }

}

