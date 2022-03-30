using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject prefabBall;

    // spawn support
    Vector2 spawnLocation = new Vector2(0, -1.5f);
    Timer spawnTimer;
    float spawnRange;

    bool retrySpawn = false;
    Vector2 spawnLocationMin;
    Vector2 spawnLocationMax;

    // Start is called before the first frame update
    void Start()
    {
        GameObject tempBall = Instantiate<GameObject>(prefabBall);
        BoxCollider2D collider = tempBall.GetComponent<BoxCollider2D>();
        float ballColliderHalfWidth = collider.size.x / 2;
        float ballColliderHalfHeight = collider.size.y / 2;
        spawnLocationMin = new Vector2(
            tempBall.transform.position.x - ballColliderHalfWidth,
            tempBall.transform.position.y - ballColliderHalfHeight);
        spawnLocationMax = new Vector2(
            tempBall.transform.position.x + ballColliderHalfWidth,
            tempBall.transform.position.y + ballColliderHalfHeight);
        Destroy(tempBall);

		// initialize and start spawn timer
        spawnRange = ConfigurationUtils.maxSpawnTime -
            ConfigurationUtils.minSpawnTime;
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.AddTimerFinishedListener(HandleSpawnTimerFinished);
        spawnTimer.Duration = GetSpawnDelay();
        spawnTimer.Run();

        // listen for lost and dead ball events
        EventManager.AddBallLostListener(SpawnBall);
        EventManager.AddBallDiedListener(SpawnBall);

        // spawn first ball in game
        SpawnBall();
    }

    /// <summary>
    /// Method to spawn balls
    /// </summary>
    void SpawnBall()
    {
        retrySpawn = false;
        if (Physics2D.OverlapArea(spawnLocationMin, spawnLocationMax) == null)
        {
            Instantiate(prefabBall);
            AudioManager.Play(AudioClipName.BallSpawn);
        }
        else
        {
            retrySpawn = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        // spawn ball and restart timer as appropriate
        if (spawnTimer.Finished)
        {
            // don't stack with a spawn still pending
            retrySpawn = false;
            SpawnBall();
            spawnTimer.Duration = GetSpawnDelay();
            spawnTimer.Run();
        }

        // try again if spawn still pending
        if (retrySpawn)
        {
            SpawnBall();
        }
    }

    float GetSpawnDelay()
    {
        return ConfigurationUtils.minSpawnTime +
            Random.value * spawnRange;
    }

    /// <summary>
    /// Handles when the spawn timer finishes
    /// </summary>
    void HandleSpawnTimerFinished()
    {
        SpawnBall();
        spawnTimer.Duration = GetSpawnDelay();
        spawnTimer.Run();
    }
}
