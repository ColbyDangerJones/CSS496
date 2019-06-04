using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using NodeInteractions;
using Valve.VR.InteractionSystem.Sample;

/*
 * Manages List of Lists
 * Each Node starts as a length 1 List
 * 
 * Arrays for memory control?
 */
public class ListManager : MonoBehaviour
{
    public List<List<GameObject>> ListOfLists = new List<List<GameObject>>();

    public GameObject prefab;

    public Valve.VR.InteractionSystem.HoverButton SpawnNodeButton;

    public ArrayList[] objective;
    public ArrayList[] current;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerable SpawnNodes()
    {
        /*
         * "ButtonEffect.cs", "ButtonExample.cs"
         * Spawns a prefab while having it scale up from a certain smallest < largest preset
         * Spawns over time 
         * Option to recolor mesh *
         */
        GameObject toSpawn = GameObject.Instantiate<GameObject>(prefab);

        toSpawn.transform.position = this.transform.position;
        toSpawn.transform.rotation = Quaternion.Euler(0, Random.value * 360f, 0);

        Rigidbody rigidbody = toSpawn.GetComponent<Rigidbody>();
        if (rigidbody != null)
            rigidbody.isKinematic = false;

        Vector3 initialScale = Vector3.one * 0.01f;
        Vector3 targetScale = Vector3.one * 0.622f;

        float startTime = Time.time;
        float overTime = 0.2f;
        float endTime = startTime + overTime;

        while (Time.time < endTime)
        {
            toSpawn.transform.localScale = Vector3.Slerp(initialScale, targetScale, (Time.time - startTime) / overTime);
            yield return null;
        }

        if (rigidbody != null)
            rigidbody.isKinematic = false;
    }
}
