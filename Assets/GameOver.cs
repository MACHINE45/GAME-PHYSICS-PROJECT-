using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameOver : MonoBehaviour
{
    bool gameHasEnded = false;

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("fuck off ");
            //Gameover();
        }
    }

    
}


