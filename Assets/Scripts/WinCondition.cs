using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    public GameObject player5;
    public GameObject player6;
    public GameObject player7;
    public GameObject player8;
    public GameObject player9;
    public GameObject player10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Moves this GameObject 2 units a second in the forward direction
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("FinalGameJam");
        }
    }

    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject == player1)
        {
            Destroy(player1);
        }
        if (other.gameObject == player2)
        {
            Destroy(player2);
        }
        if (other.gameObject == player3)
        {
            Destroy(player3);
        }
        if (other.gameObject == player4)
        {
            Destroy(player4);
        }
        if (other.gameObject == player5)
        {
            Destroy(player5);
        }
        if (other.gameObject == player6)
        {
            Destroy(player6);
        }
        if (other.gameObject == player7)
        {
            Destroy(player7);
        }
        if (other.gameObject == player8)
        {
            Destroy(player8);
        }
        if (other.gameObject == player9)
        {
            Destroy(player9);
        }
        if (other.gameObject == player10)
        {
            Destroy(player10);
        }
    }
   
}
