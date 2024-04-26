using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    bool gameEnded = false;

    public GameObject gameOverUI;
   
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Finish") && !gameEnded)
        {
            EndGame();
        }
    }
    public  void EndGame()
    {
       
        Debug.Log("Game Over"); 
        
    }
    
}
