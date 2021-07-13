using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStats : MonoBehaviour
{
    // Start is called before the first frame update
    public bool egg = false;
    public GameObject eggObject;

    private static GameStats instance;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(eggObject);
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
        
    }
}
