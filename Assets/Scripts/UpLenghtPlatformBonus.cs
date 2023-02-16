using System;
using UnityEngine;

namespace Assets.Scripts
{
    public class UpLenghtPlatformBonus:MonoBehaviour
    {
        [SerializeField] private GameObject _ballPrefab;
        private Ball refBall;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.TryGetComponent(out PlatformMove platform))
            {
                Destroy(gameObject);
                
                
                var newBall1 = Instantiate(_ballPrefab, gameObject.transform.position, Quaternion.identity);
                newBall1.SetActive(true);
                
                var newBall2 = Instantiate(_ballPrefab, gameObject.transform.position, Quaternion.identity);
                newBall2.SetActive(true);
                
                var newBall3 = Instantiate(_ballPrefab, gameObject.transform.position, Quaternion.identity);
                newBall3.SetActive(true);
                
                var barLink = refBall.GetComponent<Ball>();
                barLink.ballCount++;
                

                if (collision.gameObject.GetComponent<PlatformMove>().transform.localScale.x == 2)
                {
                    collision.gameObject.GetComponent<PlatformMove>().transform.localScale = new Vector3(4, 0.5f, 1);
                }
                else
                {
                    collision.gameObject.GetComponent<PlatformMove>().transform.localScale += new Vector3(0.5f, 0f, 1);
                }
            }
        }
    }
}