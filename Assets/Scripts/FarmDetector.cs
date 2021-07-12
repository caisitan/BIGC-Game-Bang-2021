using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class FarmDetector : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject seed;


    private bool flag = true;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        flag = false;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        flag = true;
    }
    void Update()
    {
        
        if (flag && Input.GetButtonDown("Fire1"))
        {

            GameObject newSeed = Instantiate(seed);
            newSeed.transform.position = new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y - 0.5));
            newSeed.SetActive(true);
            
        }
    }
}
