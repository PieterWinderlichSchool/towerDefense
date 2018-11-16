using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefineWayPoints : MonoBehaviour {

    //[SerializeField]
    private List<GameObject> wayPoints;

    int max = 15;

    private GameObject wayPoint;

    void Start()
    {
        wayPoints = new List<GameObject>();    
    }

    public void GenerateList()
    {
        Debug.Log("Generating list");
        for (int i = 1; i < max; i++)
        {
            if (GameObject.Find("w" + i))
            {
                Debug.Log("Found : " + "w" + i);;
                wayPoint = GameObject.Find("w" + i);
                wayPoints.Add(wayPoint.transform.GetChild(0));
            }
            else
            {
                Debug.Log("Error finding : " + "w" + i);
            }
        }
    }

    public List<GameObject> GetWayPoints()
    {
        return wayPoints;
    }

}
