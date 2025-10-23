using UnityEngine;

public class EvilBirdSpawn : MonoBehaviour
{
    public GameObject enemyPrefab;     // Enemy prefab to spawn
    public float spawnRadius = 10f;    // Distance from center
    public float spawnInterval = 2f;   // Time between spawns (seconds)
    public bool autoSpawn = true;      // Toggle auto spawning

    private float timer;

    void Update()
    {
        if (!autoSpawn) return;

        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    public void SpawnEnemy()
    {
        if (enemyPrefab == null)
        {
            Debug.LogWarning("Enemy prefab not assigned!");
            return;
        }

        // Random angle in radians
        float angle = Random.Range(0f, Mathf.PI * 2f);

        // Convert to Cartesian position
        Vector2 spawnPos = new Vector2(
            Mathf.Cos(angle) * spawnRadius,
            Mathf.Sin(angle) * spawnRadius
        );

        // Center of screen in world space
        Vector3 center = Camera.main.ScreenToWorldPoint(
            new Vector3(Screen.width / 2f, Screen.height / 2f, 0f)
        );
        center.z = 0f;

        // Final spawn position
        Vector3 worldPos = center + (Vector3)spawnPos;

        // Direction from spawn point to center
        Vector2 direction = center - worldPos;

        // Rotation toward center
        float rotationZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Spawn enemy facing the center
        Instantiate(enemyPrefab, worldPos, Quaternion.Euler(0f, 0f, rotationZ));
    }
}
