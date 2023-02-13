using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrolling : MonoBehaviour
{
    [SerializeField] private Transform _point1;
    [SerializeField] private Transform _point2;
    [SerializeField] private float _speed;
    [SerializeField] private bool _moving;

    private Vector3 _target;

    private void Start()
    {
        _target = _point1.position;
    }

    private void Update()
    {
        transform.LookAt(_target);
        Move();
    }

    public void Move()
    {
        transform.LookAt(_target);
        transform.Rotate(0, 0, 1);

        if (_moving)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);
        }

        if (transform.position == _target)
        {
            if (_target == _point1.position)
            {
                _target = _point2.position;
            }
            else if (_target == _point2.position)
            {
                _target = _point1.position;
            }
        }
    }
}
