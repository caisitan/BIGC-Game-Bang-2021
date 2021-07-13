using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoleClick : MonoBehaviour
{
    // Start is called before the first frame update
    public Text point;
    private int count;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null && hit.rigidbody == GetComponent<Rigidbody2D>() && GetComponent<SpriteRenderer>().color == Color.red)
            {
                count = int.Parse(point.text);
                count++;
                point.text = count.ToString();
            }
        }
    }
}
