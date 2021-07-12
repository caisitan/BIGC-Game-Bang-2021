using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class FarmDetector : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject seed;


    private bool plant = true;
    private bool flag = false;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        plant = false;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        plant = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "soil")
        {
            flag = true;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "soil")
        {
            flag = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        flag = false;
    }
    void Update()
    {
        
        if (flag && plant && Input.GetButtonDown("Fire1"))
        {

            GameObject newSeed = Instantiate(seed);
            newSeed.transform.position = new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y - 0.45));
            newSeed.SetActive(true);
            
        }
    }
}
