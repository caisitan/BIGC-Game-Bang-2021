using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoleGame : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] moles;
    public float countdown = 2f;
    public float interval = 0.1f;
    public Text point;
    public GameObject panel;
    public GameStats stats;

    private GameObject temp;
    private void Awake()
    {
        stats = GameObject.Find("Game Stats").GetComponent<GameStats>();
    }
    void Start()
    {
        foreach (GameObject obj in moles)
        {
            obj.GetComponent<MoleClick>().point = point;
            obj.GetComponent<MoleRed>().interval = interval;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown <= 0f)
        {
            int index = Random.Range(0, 8);
            temp = moles[index];
            temp.GetComponent<MoleRed>().changeColor();
            countdown = 2;
        }
        else
        {
            countdown -= Time.deltaTime;
        }
        if (point.text == "10")
        {
            countdown = 2;
            panel.SetActive(true);
            StartCoroutine(WaitTime());
        }
        
    }
    private IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(3);
        stats.GetComponent<GameStats>().mole = true;
        SceneManager.LoadScene("SampleScene");
    }
}
