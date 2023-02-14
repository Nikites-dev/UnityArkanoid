using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Assets.Scripts
{
    public class Ball : MonoBehaviour
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
            if (Input.GetButtonDown("Jump") && _isGrounded)
            {
                transform.SetParent(null);
                //_body2.AddForce(transform.up * _impulse);

                _body2.velocity = new Vector2(Random.Range(4f, 8f), Random.Range(4f, 8f));
                
               // _body2.AddForce(new Vector2(Random.Range(-800, 800), _impulse));
                _isGrounded = !_isGrounded;
            }
        }
    }
}