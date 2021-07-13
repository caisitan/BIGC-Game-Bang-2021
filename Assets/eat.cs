using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class eat : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other);
        Destroy(other.gameObject);
        SceneManager.LoadScene("SampleScene");
    }
}
