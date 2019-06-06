using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnOnStart : MonoBehaviour
{
    public GameObject prefab;
    public TextMeshPro Data;
    public int from;
    public int to;
    public int num;

    void Start()
    {
        for (int i = from; i >= to; i--)
        {
            GameObject toSpawn = GameObject.Instantiate(prefab);

            //GameObject toSpawn = GameObject.Instantiate<GameObject>(prefab);
            toSpawn.transform.position = this.transform.position;
            toSpawn.transform.rotation = Quaternion.Euler(0, Random.Range(-150f, -210f), 0);
            toSpawn.transform.Find("Text (TMP)").GetComponent<TextMeshPro>().text = i.ToString();
        }
    }

    // Start is called before the first frame update
    //private void Start()
    //{

    //    StartCoroutine(InstantiateObject());    
    //}

    //private IEnumerator InstantiateObject()
    //{
    //    TextMeshPro Data = prefab.GetComponent<TextMeshPro>();
    //    while (counter <= limit)
    //    {
    //        GameObject toSpawn = GameObject.Instantiate<GameObject>(prefab);
    //        toSpawn.transform.position = this.transform.position;
    //        toSpawn.transform.rotation = Quaternion.Euler(0, Random.value * 360f, 0);


    //        if (Data != null)
    //            Data.text = counter.ToString();

    //        Rigidbody rigidbody = toSpawn.GetComponent<Rigidbody>();
    //        if (rigidbody != null)
    //        {
    //            rigidbody.isKinematic = false;
    //            rigidbody.useGravity = true;
    //        }
    //        Vector3 initialScale = Vector3.one * .25f;
    //        Vector3 targetScale = Vector3.one * .25f;

    //        float startTime = Time.time;
    //        float overTime = 0.1f;
    //        float endTime = startTime + overTime;

    //        while (Time.time < endTime)
    //        {
    //            toSpawn.transform.localScale = Vector3.Slerp(initialScale, targetScale, (Time.time - startTime) / overTime);
    //            yield return null;
    //        }

    //        if (rigidbody != null)
    //        {
    //            rigidbody.isKinematic = false;
    //            rigidbody.useGravity = false;
    //        }

    //        counter++;
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
