using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    [SerializeField]private float _speed;
    [SerializeField]private float _arrivalThreshold;
    
    private Path _path;
    private Waypoints _currentWaypoints;


    private void Start()
    {
        SetupPath();
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(translation: Vector3.forward * _speed * Time.deltaTime);

        float distaneToWaypoints = Vector3.Distance(transform.position, _currentWaypoints.GetPosition());;
        if (distaneToWaypoints <= _arrivalThreshold)
        {
            if(_currentWaypoints == _path.GetPathEnd())
            {
                PathComplete();
            }
            else
            {
                _currentWaypoints = _path.GetNextWaypoints(_currentWaypoints);
                transform.LookAt(_currentWaypoints.GetPosition());
            }
        }

       // Threshold gebruiken om te kijken hoever je van de waypoint bent
       // Als afstand tussen enemy en wp kleiner is dan threshold
       // Dan moet currentwaypoint volgende waypoint worden
       // Als hij op de positie van de waypoint is zoeken naar de volgende currentwaypoint
       // Wanneer hij het einde bereikt van de waypoint despawn
       // Wanneer enemy laatste waypoint bereikt moet de enemy bekijken of het de laatste is.
    }
    
    private void SetupPath()
    {
        _path = FindObjectOfType<Path>();
        _currentWaypoints = _path.GetPathStart();
        transform.LookAt(_currentWaypoints.GetPosition());
    }


    private void PathComplete()
    {
        _speed = 0;
        Destroy(gameObject);
    }
}
