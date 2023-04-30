using UnityEngine;

namespace Assets.Scripts
{
    [RequireComponent(typeof(Collider), typeof(Rigidbody))]
    public class PickUp : MonoBehaviour
    {
        public int PointValue = 10;
        public float TimeToLive = 5f;

        private PlayerStats _playerStats;
        private GameManager _gameManager;

        private void Start()
        {
            _playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
            _gameManager = GameObject.Find(nameof(GameManager)).GetComponent<GameManager>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                _playerStats.GainPoints(PointValue);
                Destroy(gameObject);
            }
            else if (collision.gameObject.CompareTag("Ground"))
            {
                _playerStats.TakeDmg();
                Destroy(gameObject);
            }
        }
    }
}