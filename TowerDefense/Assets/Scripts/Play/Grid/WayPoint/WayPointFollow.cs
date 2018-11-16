using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointFollow : MonoBehaviour{

    private float movementSpeed = 5f;
    private float distance = Mathf.Infinity;

    private List<GameObject> _wayPoints;
    private DefineWayPoints define;

    private int targetPoint = 0;

    private void Start()
    {
        define = GameObject.Find("WayPoints").GetComponent<DefineWayPoints>();
        _wayPoints = define.GetWayPoints();
        transform.position = _wayPoints[0].transform.position + new Vector3(0f, 1f, 0f);


    }

    // Update is called once per frame
    void Update () {

        if (_wayPoints.Count > 0) {

            if (transform.position != _wayPoints[targetPoint].transform.position)
            {
                if (transform.position.x < _wayPoints[targetPoint].transform.position.x)
                {
                    Move(new Vector3(movementSpeed, 0, 0f));
                }
                else if (transform.position.x > _wayPoints[targetPoint].transform.position.x)
                {
                    Move(new Vector3(-movementSpeed, 0, 0f));
                }

                if (transform.position.z < _wayPoints[targetPoint].transform.position.z)
                {
                    Move(new Vector3(0f, 0, movementSpeed));
                }
                else if (transform.position.z > _wayPoints[targetPoint].transform.position.z)
                {
                    Move(new Vector3(0f, 0, -movementSpeed));
                }

            } else if (transform.position == _wayPoints[targetPoint].transform.position)
            {
                if(transform.position == _wayPoints[_wayPoints.Count - 1].transform.position)
                {
                    Destroy(gameObject);
                }

                if (targetPoint < _wayPoints.Count)
                {
                    targetPoint += 1;
                }
            }

            distance = Vector3.Distance(transform.position, _wayPoints[targetPoint].transform.position);

            if (distance <= movementSpeed / 50)
            {
                transform.position = _wayPoints[targetPoint].transform.position;
            }
        }
    }
    
    void Move(Vector3 dir)
    {
        transform.position += dir * Time.deltaTime;
    }

}
