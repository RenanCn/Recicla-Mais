using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

    public GameObject prefabLata;
    public GameObject prefabCoxa;
    public GameObject prefabGarrafa;

    public Canvas     canvas;

    public float      rateSpawn;
    public float      currentTime;
    private float     y;
    private float     x;
    private float     randomSpawn;


    GameObject tempPrefab;


	// Use this for initialization
	void Start () {
        currentTime = 0;
    }
	
	// Update is called once per frame
	void Update () {
        currentTime += Time.deltaTime;
        if(currentTime >= rateSpawn)
        {
            currentTime = 0;

            randomSpawn = Random.Range(0, 75);

            if (randomSpawn <= 25)
            {
                tempPrefab = Instantiate(prefabCoxa) as GameObject;
                tempPrefab.transform.SetParent(canvas.transform);

            }
            else if (randomSpawn <=50)
            {
                tempPrefab = Instantiate(prefabLata) as GameObject;
                tempPrefab.transform.SetParent(canvas.transform);
            }
            else if (randomSpawn <= 75)
            {
                tempPrefab = Instantiate(prefabGarrafa) as GameObject;
                tempPrefab.transform.SetParent(canvas.transform);
            }


            y = 6;
            x = Random.Range(-4.26f, 4.26f);
            
            tempPrefab.transform.position = new Vector3(x, y, transform.position.z);

        }
       
    }

}



