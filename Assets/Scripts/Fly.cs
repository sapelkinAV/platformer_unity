using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Fly : MonoBehaviour
    {
        Vector2 _startingPosition;
        [SerializeField] Vector2 _direction = Vector2.up;
        [SerializeField] float _maxDistance = 2;
        [SerializeField] float _speed = 2;
        

        private void Start()
        {
            _startingPosition = transform.position;
        }

        private void Update()
        {
            var directionNormalized = _direction.normalized;
            
            transform.Translate(directionNormalized * Time.deltaTime * _speed);
            var distance = Vector2.Distance(_startingPosition, transform.position);
            if (distance >= _maxDistance)
            {
                transform.position = _startingPosition + (directionNormalized * _maxDistance);
                
                _direction *= -1;
            }
        }
    }
}