using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour {

    public GameObject prefab;

    public float timeBetweenSpawns = 5f;
    private float countDown = 2f;
    private int waveCount = 1;


	// Use this for initialization
	void Start () {
       ;
        
	}
	
	// Update is called once per frame
	void Update () {

        

        if (GameObject.FindGameObjectWithTag("Enemy") == null)
        {
            StartCoroutine("SpawnWave");
        }
	}


    public IEnumerator SpawnWave()
    {
        for (int i = 0; i < waveCount; i++)
        {
            Instantiate(prefab, new Vector3 (0,0,0), Quaternion.identity);
            yield return new WaitForSeconds(.5f);
        }
        if (waveCount < 10)
        {
            waveCount++;
        }
    }


}
