using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    [SerializeField] private Transform _cubePosition;
    [SerializeField] private Transform _passDistance;

    public Transform PassDistance => _passDistance;
    public Transform CubePosition => _cubePosition;
}
