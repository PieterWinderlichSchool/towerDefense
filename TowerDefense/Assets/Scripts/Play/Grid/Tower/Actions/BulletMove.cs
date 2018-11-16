using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {

    private float speed = 30f;

    private float timeLeft = 3f;
   public TurretScript turret;
     //Use this for initialization
    void Start () {
        turret = GameObject.Find("Nuzzle").GetComponent<TurretScript>();
        transform.rotation = GameObject.Find("Nuzzle").transform.rotation;
}
	
	// Update is called once per frame
	void Update () {

        timeLeft -= Time.deltaTime;



        transform.localPosition += transform.forward * speed * Time.deltaTime;
        
        if(timeLeft <= 0f)
        {
            Object.Destroy(gameObject);
        }

    }

    public void OnCollisionEnter(Collision collision)
    {   
        if(collision.collider.name == "Enemy") {
            Object.Destroy(gameObject);
        }
        
    }
}
