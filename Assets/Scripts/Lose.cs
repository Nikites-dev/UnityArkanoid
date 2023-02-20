using UnityEngine;

namespace Assets.Scripts
{
    public class Lose:MonoBehaviour
    {
        [SerializeField] private Transform _blockBottom;
        
        private void OnCollisionEnter2D(Collision2D collision)
        {
            int crntCount = PlayerPrefs.GetInt("count");

            int countMinus = crntCount - 1;
            
            PlayerPrefs.SetInt("count", countMinus);
            

            if (PlayerPrefs.GetInt("count") == 0)
            {
                Time.timeScale = 0f;
                _blockBottom.gameObject.SetActive(true);
            }
            Destroy(gameObject);
            
            Debug.Log(PlayerPrefs.GetInt("count").ToString());
        }
    }
}