using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class FarmDetector : MonoBehaviour
{
    // Start is called before the first frame update
    public Tile highlightTile;
    public Tile originalTile;
    public Tilemap highlightMap;

    private Vector3Int previous;
    void Start()
    {
        Vector3Int currentCell = highlightMap.WorldToCell(transform.position);
        //Debug.Log(previous);
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3Int currentCell = highlightMap.WorldToCell(transform.position);
        if (currentCell != previous && Input.GetButtonDown("Fire1"))
        {

            highlightMap.SetTile(currentCell, highlightTile);
            //highlightMap.SetTile(previous, originalTile);

            // save the new position for next frame
            //previous = currentCell;
        }
    }
}
