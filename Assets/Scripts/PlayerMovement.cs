using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      transform.position = new Vector3(0,-4, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        { transform.Translate(Vector3.left * 5 * Time.deltaTime); }
        if (Input.GetKey(KeyCode.D))
        { transform.Translate(Vector3.right * 5 * Time.deltaTime); }
        // player movement

        if(transform.position.x >= 10)
        {
            transform.position = new Vector3(-9.9f, -4, 0);
        }
        else if(transform.position.x <= -10)
        {
            transform.position = new Vector3(9.9f, -4, 0);
        }
    }
}
