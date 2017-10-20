using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour {

    private int       idLevel;

    public Text       txtNota;
    public Text       txtInfoLevel;

    public GameObject medalha1;
    public GameObject medalha2;
    public GameObject medalha3;

    private int notaFinal;
    private int acertos;

	// Use this for initialization
	void Start () {

        idLevel = PlayerPrefs.GetInt("idLevel");

        medalha1.SetActive(false);
        medalha2.SetActive(false);
        medalha3.SetActive(false);

        notaFinal = PlayerPrefs.GetInt("notaFinalTemp" + idLevel.ToString());
        acertos   = PlayerPrefs.GetInt("acertosTemp" + idLevel.ToString());

        txtNota.text = notaFinal.ToString();
        txtInfoLevel.text = "Você acertou " + acertos.ToString() + " de 10 perguntas";

        if (notaFinal == 10)
        {
            medalha1.SetActive(true);
            medalha2.SetActive(true);
            medalha3.SetActive(true);
        }
        else if (notaFinal >= 6){

                medalha1.SetActive(true);
                medalha2.SetActive(true);
                medalha3.SetActive(false);
        }
        else if (notaFinal >= 3)
        {

            medalha1.SetActive(true);
            medalha2.SetActive(false);
            medalha3.SetActive(false);
        }

    }
    
    public void jogarNovamente(){
        SceneManager.LoadScene("Bloco_" + idLevel.ToString());
    }

}
