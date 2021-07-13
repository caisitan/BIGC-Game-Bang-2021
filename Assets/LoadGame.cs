using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    // Start is called before the first frame update
    public string game;
    public GameStats stats;
    private void Awake()
    {
        stats = GameObject.Find("Game Stats").GetComponent<GameStats>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (game == "Mole Game" && !stats.mole)
        {
            SceneManager.LoadScene(game);
        }else if (game == "Fish Game" && !stats.fish)
        {
            SceneManager.LoadScene(game);
        }
        else
        {
            return;
        }
        
    }
}
