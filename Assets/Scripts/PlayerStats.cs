using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerStats : MonoBehaviour
    {
        [SerializeField] private int Score;
        [SerializeField] private int Health;

        private GameManager _gameManager;
        private UIManager _uiManager;

        private void Start()
        {
            _gameManager = GameObject.Find(nameof(GameManager)).GetComponent<GameManager>();
            _uiManager = GameObject.Find(nameof(GameManager)).GetComponent<UIManager>();
            
            Health = 3;
        }

        public void TakeDmg()
        {
            Health--;

            if (Health >= 0)
                _uiManager.TakeDmg(Health);
            
            if (Health <= 0)
                _gameManager.GameOver();
        }

        public void GainPoints(int i)
        {
            Score += i;
            _uiManager.SetScoreTxt(Score);
        }
    }
}
