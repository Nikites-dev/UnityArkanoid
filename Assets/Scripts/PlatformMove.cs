using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class PlatformMove : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;
        [SerializeField] private Transform _left;
        [SerializeField] private Transform _right;

        void Update()
        {
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            var target = transform.position;
            target.x += horizontalInput;
            target.x = Mathf.Clamp(target.x, _left.position.x, _right.position.x);
            transform.position = Vector3.MoveTowards(transform.position, target, _moveSpeed);
        }
    }
}