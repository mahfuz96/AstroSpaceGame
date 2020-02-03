using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject redPrefab;
    public GameObject bluePrefab;
    public float platform_Spawn_Timer = 1f;
    private float current_Platform_Spawn_Timer = 1f;
    private int platform_Spawn_Count;

    public float min_Y, max_Y;

    // Start is called before the first frame update
    void Start()
    {
        current_Platform_Spawn_Timer = platform_Spawn_Timer;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnPlatforms();
    }

    void SpawnPlatforms()
    {
        current_Platform_Spawn_Timer += Time.deltaTime;
        if (current_Platform_Spawn_Timer >= platform_Spawn_Timer)
        {
            platform_Spawn_Count++;

            Vector3 temp = transform.position;
            temp.y = Random.Range(min_Y, max_Y);

            GameObject newPlatform = null;
            if (platform_Spawn_Count < 2)
            {
                newPlatform = Instantiate(redPrefab, temp, Quaternion.identity);
            }
            else if (platform_Spawn_Count == 2)
            {
                if (Random.Range(0, 3) > 0)
                {
                    newPlatform = Instantiate(bluePrefab, temp, Quaternion.identity);
                }
                else
                {
                    newPlatform = Instantiate(redPrefab, temp, Quaternion.identity);
                }
            }
            else if (platform_Spawn_Count == 3)
            {
                if (Random.Range(0, 3) > 0)
                {
                    newPlatform = Instantiate(redPrefab, temp, Quaternion.identity);
                }
                else
                {
                    newPlatform = Instantiate(bluePrefab, temp, Quaternion.identity);
                }
            }
            else if (platform_Spawn_Count == 4)
            {
                if (Random.Range(0, 4) > 0)
                {
                    newPlatform = Instantiate(bluePrefab, temp, Quaternion.identity);
                }
                else
                {
                    newPlatform = Instantiate(redPrefab, temp, Quaternion.identity);
                }
                platform_Spawn_Count = 0;
            }

            newPlatform.transform.parent = transform;
            current_Platform_Spawn_Timer = 0f;
        }
    }
}
