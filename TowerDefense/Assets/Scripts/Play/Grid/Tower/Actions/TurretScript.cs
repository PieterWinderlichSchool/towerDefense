using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour {

    private Shoot shoot;
    public Transform target;
    private float range = 15f;
    private float fireRate = 1.5f;
    private float timeLeft = 0f;

    // Use this for initialization
    void Start () {
        shoot = GetComponent<Shoot>();
        InvokeRepeating("UpdateTarget", 0f, 1f / 3);
    }

    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
            if (distanceToEnemy > 15f)
            {
                target = null;
            }
        }
        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
            if (timeLeft < 0)
            {
                timeLeft = fireRate;
                shoot.ShootBullet();
            }
        } 
    }
	// Update is called once per frame
	void Update () {

        timeLeft -= Time.deltaTime;


        if (target == null)
        {
            return;
        }
        transform.LookAt(target);
	}
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
