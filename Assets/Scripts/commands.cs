﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class commands : MonoBehaviour {

    public void carregaCena(string nomeCena){
        SceneManager.LoadScene(nomeCena);
    }

    public void sair(){
        Application.Quit();
    }

}
