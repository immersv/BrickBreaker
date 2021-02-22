using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawn : MonoBehaviour
{
    public GameObject brick;
    public float offset;
    public GameObject[] brickArray;
    // Start is called before the first frame update
    void Start()
    {
        brickArray = new GameObject[7];
        for(int i = 0; i < brickArray.Length; i++)
        {
           transform.position = new Vector3(transform.position.x+2.0f, 10.0f, 0);
           brickArray[i]= Instantiate(brick,  transform.position, Quaternion.identity);
            
        }
        int randValue = Random.Range(1, brickArray.Length);
        brickArray[randValue].tag = "SuperBrick";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
