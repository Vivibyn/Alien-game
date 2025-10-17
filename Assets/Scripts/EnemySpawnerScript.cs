using System.Collections;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject objectToSpawn;//Check
    public int spawnLimit; //Check
    public Vector3 spawnLocation;//Check
    public float spawnCool_Down;//Check

    private int spawnCounter = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(ObjectSpawner()); 
    }

    IEnumerator ObjectSpawner()
    {
        while (spawnCool_Down > 0)
        {
            spawnLocation = new Vector3(Random.Range(11f, -11f), 6, 0);
            if(spawnCounter < spawnLimit)
            {
                spawnCounter = spawnCounter + 1;
                Instantiate(objectToSpawn, spawnLocation, transform.rotation);
            }
            yield return new WaitForSeconds(spawnCool_Down);
        }
        yield return null;
    }
}
