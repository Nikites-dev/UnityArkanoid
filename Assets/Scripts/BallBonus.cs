using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Assets.Scripts
{
    public class BallBonus : MonoBehaviour
    {
        [SerializeField] private float _impulse;
        private Rigidbody2D _body2;
        private bool _isGrounded = true;
        
        private void Awake()
        {
            _body2 = GetComponent<Rigidbody2D>();
       
        }

        private void Update()
        {
            if (_isGrounded)
            {
                // transform.SetParent(null);
                _body2.velocity = new Vector2(Random.Range(4f, 8f), Random.Range(4f, 8f));
                _isGrounded = !_isGrounded;
            }
        }
    }
}