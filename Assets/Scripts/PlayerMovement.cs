using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int playerHealth;
    public GameObject Laser;
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
        //Move left and right
        if(transform.position.x >= 10)
        {
            transform.position = new Vector3(-9.9f, -4, 0);
        }
        else if(transform.position.x <= -10)
        {
            transform.position = new Vector3(9.9f, -4, 0);
        }
        //Screenwrap

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Laser,transform.position +new Vector3(0, 1, 0),transform.rotation);
        }
        //Laser schüt

        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gameObject);
        }
    }   // :,( Sosad...
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit: " + other);
        if (other.tag == "Laser")
        {
            Destroy(gameObject);
        }
        playerHealth--;
        //CHANGE LATER PLEEEASE
        Debug.Log("Player health: " + playerHealth);

        if (playerHealth < 0)
        {
            Destroy(gameObject);
        }
    }
    public void TakeDamage()
    {
        playerHealth = playerHealth - 1;
    }
  
}
