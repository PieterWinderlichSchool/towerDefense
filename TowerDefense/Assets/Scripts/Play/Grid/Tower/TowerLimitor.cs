using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLimitor : MonoBehaviour {

    private List<GameObject> towers;

    private float timeLimit = 2.5f;
    private float timeLeft = 0f;

    private int max = 5;

	void Start () {
        towers = new List<GameObject>();
	}
	

	void Update () {

        timeLeft -= Time.deltaTime;

        if(timeLeft <= 0f)
        {
            timeLeft = timeLimit;
            RemoveTower();
        }

        if (towers.Count > max)
        {
            RemoveTower();
        }
	}

    public void RemoveTower()
    {
        towers[0].transform.parent.GetComponent<Land>().RemoveTower();
        Destroy(towers[0]);
        towers.RemoveAt(0);
    }

    public void AddTower(GameObject go)
    {
        towers.Add(go);
        //timeLeft = timeLimit;
    }
}
