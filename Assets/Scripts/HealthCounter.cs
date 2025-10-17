using UnityEngine;

public class HealthCounter : MonoBehaviour
{
    public GameObject HPOne;
    public GameObject HPTwo;
    public GameObject HPThree;
    public int playerHealthCounter = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHealthCounter == 3)
        {
            HPOne.SetActive(true);
            HPTwo.SetActive(true);
            HPThree.SetActive(true);
        }

        else if(playerHealthCounter == 2)
        {
            HPOne.SetActive(false);
            HPTwo.SetActive(true);
            HPThree.SetActive(true);
        }

        else if (playerHealthCounter == 1)
        {
            HPOne.SetActive(false);
            HPTwo.SetActive(false);
            HPThree.SetActive(true);
        }

        else if (playerHealthCounter == 0)
        {
            HPOne.SetActive(false);
            HPTwo.SetActive(false);
            HPThree.SetActive(false);
        }
    }
}
