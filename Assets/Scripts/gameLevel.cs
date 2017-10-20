using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameLevel : MonoBehaviour {

    public Button     btnPlay;
    public GameObject infoLevel;
    public Text       txtInfoLevel;

    public int numeroQuestoes;
    
    private int       idLevel;

	// Use this for initialization
	void Start () {
     // idLevel = 0;
        infoLevel.SetActive(true);
        txtInfoLevel.text = "SELECIONE UM QUIZ";
        btnPlay.interactable = false;
	}
	
    public void levelSelect (int i){
        idLevel = i;

        PlayerPrefs.SetInt("idLevel", idLevel);

        int acertos = PlayerPrefs.GetInt("acertos" + idLevel.ToString());

        txtInfoLevel.text = "Você acertou " + acertos.ToString() + " de 10 perguntas!";
        btnPlay.interactable = true;
    }

    public void play(){
        SceneManager.LoadScene("Bloco_"+idLevel.ToString());

    }
		
} 

