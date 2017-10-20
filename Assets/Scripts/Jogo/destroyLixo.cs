using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class destroyLixo : MonoBehaviour {

    private static int pontuacao;
    private static int record;

    public Text        txtPlacar;

    // Update is called once per frame
    void Update () {
        txtPlacar.text = "Pontuação: " +pontuacao.ToString() + "\nRecorde: " + PlayerPrefs.GetInt("record", record).ToString();

        if (transform.position.y <= -4.00f)
        {
            pontuacao = 0;
            Destroy(transform.gameObject);

        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        pontuacao++;
        PlayerPrefs.SetInt("pontuacao", pontuacao);
        //  Debug.Log(pontuacao);
        Destroy(transform.gameObject);
        if (pontuacao > PlayerPrefs.GetInt("record"))
        {
          //  record = PlayerPrefs.GetInt("pontuacao", pontuacao);
            PlayerPrefs.SetInt("record", pontuacao);
        //    Debug.Log(record);
        }

    }

}
