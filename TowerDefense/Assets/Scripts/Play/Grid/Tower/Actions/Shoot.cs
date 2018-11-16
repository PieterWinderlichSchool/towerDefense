using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
        
    public GameObject bullet;

    public void ShootBullet()
    {
        Instantiate(bullet, transform.position, transform.rotation);
    }
}
