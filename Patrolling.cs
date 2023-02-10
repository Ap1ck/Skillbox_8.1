using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrolling : MonoBehaviour
{
    [SerializeField] private List<Transform> _cubesList;
    [SerializeField] private float _speed;
    [SerializeField] private bool _moving;

    public Distance _distance;

    private Vector3 _target;

    private void Start()
    {
        _target = _distance.PassDistance.position;
    }

    private void Update()
    {
        transform.LookAt(_target);
        Move();
    }

    public void Move()
    {
        if (_moving)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);
        }
    }

}
