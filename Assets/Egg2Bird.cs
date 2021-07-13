using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg2Bird : MonoBehaviour
{
    private GameObject egg;
    private Transform temp;
    private bool actived = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        temp = collision.transform.Find("egg");
        if (temp != null && !actived)
        {
            egg = temp.gameObject;
            Destroy(egg);
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
    
    
}
