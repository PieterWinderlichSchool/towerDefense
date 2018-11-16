using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour {


    public int health = 2;
    

	void Update () {
		if(health <= 0)
        {
            Object.Destroy(gameObject);
        }
	}


    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Bullet")
        {
            health--;
            Debug.Log("HP : " + health);
        }
        
    }
}
