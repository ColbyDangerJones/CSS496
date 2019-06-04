using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem.Sample
{
    public class ButtonExample : MonoBehaviour
    {
        public HoverButton hoverButton;

        public GameObject prefab;

        private void Start()
        {
            hoverButton.onButtonDown.AddListener(OnButtonDown);
        }

        private void OnButtonDown(Hand hand)
        {
            StartCoroutine(InstantiateObject());
        }

        private IEnumerator InstantiateObject()
        {
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
}