using UnityEngine;

namespace Assets.Scripts
{
    [RequireComponent(typeof(PlayerController))]
    public class PlayerInput : MonoBehaviour
    {
        private PlayerController _playerController;
        private GameManager _gameManager;

        private void Awake()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        private void Start()
        {
            _playerController = GetComponent<PlayerController>();
            _gameManager = GameObject.Find(nameof(GameManager)).GetComponent<GameManager>();
        }

        private void FixedUpdate()
        {
            if (!_gameManager.IsGameOver)
                GetInput();
        }

        private void GetInput()
        {
            _playerController.Move(Input.GetAxis("Mouse X"));
        }
    }
}
