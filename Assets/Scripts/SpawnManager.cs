using UnityEngine;
using System.Collections;

namespace Assets.Scripts
{
    public class SpawnManager : MonoBehaviour
    {
        public GameObject ObjectToSpawn;
        
        public float SpawnRate = 3f;
        public float MinSpawnRate = 0.3f;
        public float SpawnRateDecrease = 0.1f;

        private float _spawnBoundaries = 15f;
        private GameManager _gameManager;

        private void Start()
        {
            _gameManager = GameObject.Find(nameof(GameManager)).GetComponent<GameManager>();

            StartCoroutine(Spawn());
        }

        private IEnumerator Spawn()
        {
            yield return new WaitForSeconds(SpawnRate);

            while (!_gameManager.IsGameOver)
            {
                SpawnRate -= SpawnRateDecrease;
                SpawnRate = Mathf.Max(SpawnRate, MinSpawnRate);

                Vector3 spawnPos = new Vector3
                    (
                       0f,
                       20f,
                       Random.Range(-_spawnBoundaries, _spawnBoundaries)
                    );

                Instantiate(ObjectToSpawn, spawnPos, ObjectToSpawn.transform.rotation);
            
                yield return new WaitForSeconds(SpawnRate);
            }
        }
    }
}