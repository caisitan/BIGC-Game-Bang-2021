using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleRed : MonoBehaviour
{
    public float interval;

    // Start is called before the first frame update
    public void changeColor()
    {
        GetComponent<SpriteRenderer>().color = Color.red;

        StartCoroutine(WaitTime());
    }
    private IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(interval);
        
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
