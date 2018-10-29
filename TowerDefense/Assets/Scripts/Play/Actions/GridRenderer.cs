using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridRenderer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Grid myGrid = new Grid(20, 20);
		print (myGrid.GetTile (10, 10).IsBlocking);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
