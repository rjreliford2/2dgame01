using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SpawnPlatforms : MonoBehaviour
{
    public GameObject platformPrefab;
    private string[] _first = new string[5];
    private string[] _second = new string[9];

    void Start()
    {
        RandomSpawn();
    }
    
    public void RandomSpawn()
    {
        Instantiate(platformPrefab, new Vector2(this.transform.position.x - 1f, this.transform.position.y + (UnityEngine.Random.Range(1f, 3.5f))), quaternion.identity);
        for (int index = 0; index < _first.Length; index++)
        {
            float height = UnityEngine.Random.Range(1f, 3.5f);
            Instantiate(platformPrefab, new Vector2(this.transform.position.x * (index + 1f) * -9f, this.transform.position.y + height), quaternion.identity);
        }
        for (int index = 0; index < _second.Length; index++)
        {
            float height = UnityEngine.Random.Range(1f, 3.5f);
            Instantiate(platformPrefab, new Vector2((this.transform.position.x * (index + 1f) * 5f), this.transform.position.y + height), quaternion.identity);
        }
    }
}