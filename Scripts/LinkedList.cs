using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedList : MonoBehaviour
{

    List<int> Nodes = new List<int>();
    public GameObject prefab;
    public int iListCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
        //Node node = new Node();
    }

    // Update is called once per frame
    void Update()
    {
        //int iListCounter = 0;
        if (Input.GetKeyDown(KeyCode.Space) && iListCounter == 0)
        {
            Nodes.Add(Random.Range(0, 49));
            ++iListCounter;
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            Nodes.Add(Random.Range(50, 100));
            ++iListCounter;
        }
    }

    void CreateList()
    {
        
        //LinkedList<GameObject> ListCounter = new LinkedList<GameObject>();
        //++ListCounter;
    }
}
