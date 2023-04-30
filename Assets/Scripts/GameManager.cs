using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class GameManager : MonoBehaviour
    {
        public GameObject GameOverUI;
        public bool IsGameOver;

        private void Start()
        {
            IsGameOver = false;
            GameOverUI.SetActive(false);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.R) && IsGameOver)
                RestartGame();
        }

        public void RestartGame()
        {
            Debug.Log("Restarting");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void GameOver()
        {
            IsGameOver = true;

            GameOverUI.SetActive(true);

            Debug.Log($"Game Over");
        }
    }
}
