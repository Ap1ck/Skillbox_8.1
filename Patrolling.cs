using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrolling : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _point1;
    [SerializeField] private Transform _point2;

    public bool _moving;

    private Vector3 _vector;

    private void Start()
    {
        _vector = _point1.position;
    }

    private void Update()
    {
        transform.LookAt(_vector);
        transform.Rotate(0, 0, 2);

        if (_moving)
        {
            transform.position = Vector3.MoveTowards(transform.position, _vector, _speed * Time.deltaTime);
        }

        if (transform.position == _vector)
        {
            if (_vector == _point1.position)
            {
                _vector = _point2.position;
            }
            else if (_vector == _point2.position)
            {
                _vector = _point1.position;
            }
        }
    }

}
