using UnityEngine;
using System;

public class LauncherSpawner : MonoBehaviour
{

    // Launcher Prefab assignment
    [SerializeField]
    GameObject chainsawLauncher;

    [SerializeField]
    GameObject pirateLauncher;

    [SerializeField]
    GameObject zombieLauncher;

    [SerializeField]
    Timer timer;

    int LauncherSpawnerCount;



    void Start()
    {

        LauncherSpawnerCount = 0;

        timer = gameObject.AddComponent<Timer>();

        timer.Duration = 5;

        timer.Run();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject launcherToSpawn;

        if (timer != null && timer.Finished)
        {
            switch (LauncherSpawnerCount)
            {
                case 0:
                    launcherToSpawn = chainsawLauncher;
                    break;

                case 1:
                    launcherToSpawn = pirateLauncher;
                    break;

                case 2:
                    launcherToSpawn = zombieLauncher;
                    break;

                default:
                    launcherToSpawn = null;
                    break;
            }

            if (launcherToSpawn != null)
            {
                Instantiate(launcherToSpawn);
                LauncherSpawnerCount++;
                timer.Run();
            }
        }
    }
}
