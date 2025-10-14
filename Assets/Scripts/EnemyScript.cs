using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
public class EnemyScript : MonoBehaviour
{
    public GameObject enemyLaser;
    //Variablés

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(laser());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * 2 * Time.deltaTime);

        if (transform.position.y <= -5.5f)
        {
            transform.position = new Vector3(Random.Range(-8, 8), 5.5f, 0);
        }
        //Enemy loops if at bottom of screen, spawning in a random location

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Laser")
        {
            Destroy(gameObject);
        }
    }
    IEnumerator laser()
    {
        while (true) 
        {
            Instantiate(enemyLaser, new Vector3(transform.position.x, transform.position.y - 0.6f, 0), Quaternion.identity);
          
            yield return new WaitForSeconds(2);
        }
    }
}