using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public GameObject figurixPrefab;
    public float gutter = 10f;
    // Start is called before the first frame update
    void Start()
    {
        // build the board with prefabs
        for (int row = 1; row <=6; row++)
        {
            for (int col = 1; col <= 3; col++)
            {
                // count offset, row: prefab.height + gutter; column: prefab.height + gutter
                var figurix = Instantiate(figurixPrefab, new Vector3(0, 0, 0), Quaternion.identity);
               
                var w = figurix.GetComponent<CircleCollider2D>().bounds.size.x;
                var h = figurix.GetComponent<CircleCollider2D>().bounds.size.y;

                var x = (row * w) + (row * gutter);
                var y = (col * h) + (col * gutter);
                figurix.transform.SetPositionAndRotation(new Vector3(x, y, 0), Quaternion.identity);
                Debug.Log($"x: {x}, y: {x}, widht: {w} height: {h}");
            }
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
