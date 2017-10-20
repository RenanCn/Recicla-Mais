using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelInfo : MonoBehaviour {

    public int        idLevel;

    public GameObject medalha1;
    public GameObject medalha2;
    public GameObject medalha3;

    private int notaFinal;

    // Use this for initialization
    void Start () {
        medalha1.SetActive(false);
        medalha2.SetActive(false);
        medalha3.SetActive(false);

        notaFinal = PlayerPrefs.GetInt("notaFinal" + idLevel.ToString());

        if (notaFinal == 10)
        {
            medalha1.SetActive(true);
            medalha2.SetActive(true);
            medalha3.SetActive(true);
        }
        else if (notaFinal >= 6)
        {

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
	
}
