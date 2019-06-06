using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class SpawnOnHover : MonoBehaviour
{
    Valve.VR.InteractionSystem.Hand currentHand;

    public GameObject prefab;
    int counter = 0;
    int limit = 20;
    // Start is called before the first frame update


    private void Awake()
    {
        
    }
    void Start()
    {
        currentHand = FindObjectOfType<Valve.VR.InteractionSystem.Hand>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(InstantiateObject());
        currentHand.TriggerHapticPulse(1000);
    }

    private IEnumerator InstantiateObject()
    {
        while (counter <= limit)
        {
            GameObject toSpawn = GameObject.Instantiate<GameObject>(prefab);
            toSpawn.transform.position = this.transform.position;
            toSpawn.transform.rotation = Quaternion.Euler(0, Random.value * 360f, 0);

            Rigidbody rigidbody = toSpawn.GetComponent<Rigidbody>();
            if (rigidbody != null)
                rigidbody.isKinematic = false;

            Vector3 initialScale = Vector3.one * 1f;
            Vector3 targetScale = Vector3.one * 1f;

            float startTime = Time.time;
            float overTime = 0.8f;
            float endTime = startTime + overTime;

            while (Time.time < endTime)
            {
                toSpawn.transform.localScale = Vector3.Slerp(initialScale, targetScale, (Time.time - startTime) / overTime);
                yield return null;
            }

            if (rigidbody != null)
                rigidbody.isKinematic = false;

            counter++;
        }
    }
}
