using UnityEngine;

namespace Assets.Scripts
{
    public class Lose:MonoBehaviour
    {
        [SerializeField] private Transform _blockBottom;
        
        private void OnCollisionEnter2D(Collision2D collision)
        {
            Destroy(gameObject);
            _blockBottom.gameObject.SetActive(true);
        }
    }
}