using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _arrivalTreshold;
    private Path _path;
    private Waypoints _currentWaypoint;

    private void Start()
    {
        SetUpPath();
    }
    private void SetUpPath()
    {
        _path = FindObjectOfType<Path>();
        _currentWaypoint = _path.GetPathStart();
        transform.LookAt(_currentWaypoint.GetPosition());
    }
    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);

        float distanceToWaypoint = Vector3.Distance(transform.position, _currentWaypoint.GetPosition());
        if (distanceToWaypoint <= _arrivalTreshold)
        {
            if(_currentWaypoint == _path.GetPathEnd())
            {
                PathComplete();
            }
            else
            {
                _currentWaypoint = _path.GetNextWaypoint(_currentWaypoint);
                transform.LookAt(_currentWaypoint.GetPosition());
            }
        }

    }
    private void PathComplete()
    {
        _speed = 0;
        FindObjectOfType<PlayerHealthComponent>().TakeDamage(5);
        Destroy(this.gameObject);
    }
}
