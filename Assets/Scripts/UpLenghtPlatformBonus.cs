using System;
using UnityEngine;

namespace Assets.Scripts
{
    public class UpLenghtPlatformBonus:MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.TryGetComponent(out PlatformMove platform))
            {
                Destroy(gameObject);
                if (collision.gameObject.GetComponent<PlatformMove>().transform.localScale.x == 2)
                {
                    collision.gameObject.GetComponent<PlatformMove>().transform.localScale = new Vector3(4, 0.5f, 1);
                }
                else
                {
                    collision.gameObject.GetComponent<PlatformMove>().transform.localScale = new Vector3(6, 0.5f, 1);
                }
            }
        }
    }
}