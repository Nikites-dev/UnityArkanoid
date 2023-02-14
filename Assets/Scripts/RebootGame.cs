using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class RebootGame:MonoBehaviour
    {
        public void Reset()
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1.0f;
        }
    }
}