using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrolling : MonoBehaviour
{
    [SerializeField] private List<Transform> _allPointList;
    [SerializeField] private float _speed;
    [SerializeField] private bool _moving;

    private Vector3 _target;
    private int _index = 0;

    private void Start()
    {
        _target = _allPointList[_index].position;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Rotate(0, 0, 1);
        transform.LookAt(_target);

        transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);

        if (transform.position == _target)
        {
            if (_target == _allPointList[_index++].position)
            {
                _target = _allPointList[_index].position;
            }
            else if (_target == _allPointList[_index--].position)
            {
                _target = _allPointList[_index].position;
            }
        }
    }
}
