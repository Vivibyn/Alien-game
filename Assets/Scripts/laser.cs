using UnityEngine;

public class laser : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(Vector3.up * 5 * Time.deltaTime); 
     
        if(transform.position.y >= 6) 
        {
            Destroy(gameObject);
        }

        if(transform.position.y <= -6) 
        {
            Destroy(gameObject);
        }
    }

}
