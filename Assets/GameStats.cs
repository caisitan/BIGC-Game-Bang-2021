using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStats : MonoBehaviour
{
    // Start is called before the first frame update
    public bool egg = false;
    public GameObject eggObject;
    public bool fish = false;
    public GameObject fishObject;
    public bool mole = false;
    public bool bird = false;

    private static GameStats instance;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(eggObject);
        DontDestroyOnLoad(fishObject);
        
    }
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (fish && SceneManager.GetActiveScene().name == "SampleScene")
        {
            fishObject.SetActive(true);
        }
    }
}
