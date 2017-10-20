using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //biblioteca da versao nova

public class resposta : MonoBehaviour {

    private int      idLevel;

    public Text     pergunta;
    public Text     respostaA;
    public Text     respostaB;
    public Text     respostaC;
    public Text     respostaD;
    public Text     infoRespostas;

    public string[] perguntas;
    public string[] respA;
    public string[] respB;
    public string[] respC;
    public string[] respD;
    public string[] corretas;

    private int     idPergunta;

    private int     notaFinal;
    private float   acertos;
    private float   questoes;
    private float   media;

    // Use this for initialization
    void Start () {
        idLevel = PlayerPrefs.GetInt("idLevel");
        idPergunta = 0;
        questoes = perguntas.Length;

        pergunta.text = perguntas[idPergunta];

        respostaA.text = respA[idPergunta];
        respostaB.text = respB[idPergunta];
        respostaC.text = respC[idPergunta];
        respostaD.text = respD[idPergunta];

        infoRespostas.text = (idPergunta + 1).ToString() + " de " + questoes.ToString();
    }
	
	public void respostaCorreta(string alternativa){
        switch (alternativa) {
            case "A":
                if (respA[idPergunta] == corretas[idPergunta]){
                    acertos++;
                }
                    break;
            case "B":
                if (respB[idPergunta] == corretas[idPergunta]){
                    acertos++;
                }
                break;
            case "C":
                if (respC[idPergunta] == corretas[idPergunta]){
                    acertos++;
                }
                break;
            case "D":
                if (respD[idPergunta] == corretas[idPergunta]){
                    acertos++;
                }
                break;
        }

        Debug.Log("Acertos: "+ acertos);
        proximaPergunta();
    }


    void proximaPergunta(){
        idPergunta++;

        if (idPergunta <= (questoes - 1)){
            pergunta.text = perguntas[idPergunta];
            respostaA.text = respA[idPergunta];
            respostaB.text = respB[idPergunta];
            respostaC.text = respC[idPergunta];
            respostaD.text = respD[idPergunta];

            infoRespostas.text = (idPergunta + 1).ToString() + " de " + questoes.ToString();
        }
        else {
            //Debug.Log("chegou aqui");
            media = 10 * (acertos / questoes);
            notaFinal = Mathf.RoundToInt(media);

            if(notaFinal > PlayerPrefs.GetInt("notaFinal"+idLevel.ToString())){
                PlayerPrefs.SetInt("notaFinal" + idLevel.ToString(), notaFinal);
                PlayerPrefs.SetInt("acertos" + idLevel.ToString(), (int)acertos);
            }

            PlayerPrefs.SetInt("notaFinalTemp" + idLevel.ToString(), notaFinal);
            PlayerPrefs.SetInt("acertosTemp" + idLevel.ToString(), (int)acertos);

            SceneManager.LoadScene("nota");
        }
    }
  }

