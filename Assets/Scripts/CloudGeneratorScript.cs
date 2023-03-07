using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGeneratorScript : MonoBehaviour
{
    [SerializeField]
    GameObject[] clouds;

    [SerializeField]
    float spawnInterval;

    [SerializeField]
    GameObject endPoint;

    Vector3 startPos;

    [SerializeField]
    GameObject GameParent;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        PreWarm();
        Invoke("AttemptSpawn", spawnInterval);
    }

    // Update is called once per frame
    void SpawnCloud(Vector3 startPos)
    {
        int randomIndex = UnityEngine.Random.Range(0, clouds.Length);
        GameObject cloud = Instantiate(clouds[randomIndex]);

        float startY = UnityEngine.Random.Range(startPos.y - 500f, startPos.y + 500f);

        cloud.transform.position = new Vector3(startPos.x, startY, startPos.z);
        cloud.transform.parent = GameParent.transform;
        cloud.transform.SetSiblingIndex(0);

        float scale = UnityEngine.Random.Range(0.3f, 0.6f);
        cloud.transform.localScale = new Vector2(scale, scale);

        float speed = UnityEngine.Random.Range(30f, 100f);
        cloud.GetComponent<CloudScript>().StartFloating(speed, endPoint.transform.position.x);
    }

    void AttemptSpawn()
    {
        SpawnCloud(startPos);

        Invoke("AttemptSpawn", spawnInterval);
    }

    void PreWarm()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 spawnPos = startPos + Vector3.right * (i * 200);
            SpawnCloud(spawnPos);
        }
    }
}
