using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg2Bird : MonoBehaviour
{
    public GameStats stats;

    private GameObject egg;
    private Transform temp;
    private bool actived = false;
    private void Awake()
    {
        stats = GameObject.Find("Game Stats").GetComponent<GameStats>();
    }
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
            StartCoroutine(Birth(egg, collision));
            Transform temp2 = transform.Find("bird");
            temp2.parent = collision.gameObject.transform;
            temp2.position = collision.gameObject.transform.Find("Object point").gameObject.transform.position;
            actived = true;
            GetComponent<BoxCollider2D>().enabled = false;
            
            
        }
    }
    IEnumerator Birth(GameObject egg, Collider2D obj)
    {
        yield return new WaitForSeconds(5);
        egg.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        obj.transform.Find("bird").gameObject.SetActive(true);
        stats.bird = true;

    }
    
    
}
