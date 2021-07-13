using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg2Bird : MonoBehaviour
{
    private GameObject egg;
    private bool actived = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        egg = collision.transform.Find("egg").gameObject;
        if (egg != null && !actived)
        {
            egg = transform.Find("incubator").gameObject;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            egg.GetComponent<SpriteRenderer>().enabled = true;
            StartCoroutine(Birth(egg));
            actived = true;
            GetComponent<BoxCollider2D>().enabled = false;
            
            
        }
    }
    IEnumerator Birth(GameObject egg)
    {
        yield return new WaitForSeconds(5);
        egg.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        transform.Find("bird").gameObject.SetActive(true);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
