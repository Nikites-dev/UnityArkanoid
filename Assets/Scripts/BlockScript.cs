using System;
using UnityEngine;
using Random = System.Random;

namespace Assets.Scripts
{
    public class BlockScript:MonoBehaviour
    {
        [SerializeField] private GameObject _bonusPrefab;

        private void OnCollisionEnter2D(Collision2D collision)
        {
           Destroy(gameObject);

           Random random = new Random();

           int num = random.Next(0, 8);

           if (num == 5)
           {
               var bonus = Instantiate(_bonusPrefab, gameObject.transform.position, Quaternion.identity);
               bonus.SetActive(true);
           } 
           
           
        }
    }
}