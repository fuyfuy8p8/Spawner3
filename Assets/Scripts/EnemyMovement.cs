using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
     private Vector3 _playerTransform;
    [SerializeField] private float _speed;

    private void Start()
    {
        _playerTransform = FindObjectOfType<FirstPersonMovement>().transform.position;
    }

    private void Update()
    {
        if (_playerTransform != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, _playerTransform, _speed * Time.deltaTime);
            transform.LookAt(_playerTransform);
        }
    }
}
