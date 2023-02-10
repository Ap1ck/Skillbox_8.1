using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    [SerializeField] private Transform _cubePosition;
    [SerializeField] private Transform _passDistance;
    [SerializeField] private float _speed;

    public bool _moving;

    private Vector3 _target;

    private void Start()
    {
        _target = _passDistance.position;
    }

    private void Update()
    {
        transform.LookAt(_target);
        Move();
    }

    public void Move()
    {
        if (_cubePosition.position != _passDistance.position)
        {
            if (_moving)
            {
                transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);
            }
        }
    }
}
