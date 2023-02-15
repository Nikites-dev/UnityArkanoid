using System;
using UnityEngine;

namespace Assets.Scripts
{
    public class BlockScript2:MonoBehaviour
    {
        private int count = 1;
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (count == 2)
            {
                Destroy(gameObject);     
            } 
            gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
            count++;
        }
    }
}