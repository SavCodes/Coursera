using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    [Header("Prefab Assignment")]
    public GameObject greenBall;
    public GameObject redBall;
    public GameObject ball;

    [Header("Spawn Timer Assignment")]
    public Timer spawnTimer;


    void Start()
    {
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = 1;
        spawnTimer.Run();
    }

    // Update is called once per frame
    void Update()
    {
       if (spawnTimer.Finished)
        {
            spawnTimer.Run();
            SpawnBall();
        }
    }

    void SpawnBall()
    {
        int ballChoice = Random.Range(0, 3);
        GameObject ballToSpawn;

        switch (ballChoice)
        {
            case 0:
                ballToSpawn = ball;
                break;

            case 1:
                ballToSpawn = greenBall;
                break;

            case 2:
                ballToSpawn = redBall;
                break;

            default:
                ballToSpawn = ball;
                Debug.Log(ballChoice);
                break;
        }

        Instantiate(ballToSpawn);
    }

}
