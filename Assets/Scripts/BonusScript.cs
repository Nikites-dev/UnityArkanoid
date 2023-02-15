using System;
using UnityEngine;

namespace Assets.Scripts
{
    public class BlockScript:MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
           Destroy(gameObject);
        }
    }
}