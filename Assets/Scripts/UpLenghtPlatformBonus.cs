using System;
using UnityEngine;
using Random = System.Random;

namespace Assets.Scripts
{
    public class UpLenghtPlatformBonus:MonoBehaviour
    {
        [SerializeField] private GameObject _ballPrefab;
        private Ball refBall;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            
            Random random = new Random();

            int num = random.Next(0, 2);

            if (num == 0)
            {
                var newBall1 = Instantiate(_ballPrefab, _ballPrefab.transform.position, Quaternion.identity);
                newBall1.SetActive(true);
                
                var newBall2 = Instantiate(_ballPrefab, _ballPrefab.transform.position, Quaternion.identity);
                newBall2.SetActive(true);
                
                var newBall3 = Instantiate(_ballPrefab, _ballPrefab.transform.position, Quaternion.identity);
                newBall3.SetActive(true);
                
                // var barLink = refBall.GetComponent<Ball>();
                // barLink.ballCount++;
                
                
                int crntCount = PlayerPrefs.GetInt("count");
                int newcCount = crntCount + 3;
                PlayerPrefs.SetInt("count", newcCount);

            }
            else
            {
                if (collision.gameObject.TryGetComponent(out PlatformMove platform))
                {
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
            Destroy(gameObject);
        }
    }
}