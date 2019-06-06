using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGarage : MonoBehaviour
{
    public GameObject Display;

    public GameObject door;
    // Start is called before the first frame update

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody>() != null && collision.gameObject.tag == "ScreenNode")
        {
            collision.gameObject.GetComponent<AudioSource>().Pause();


            door.GetComponent<Animation>().Play();
            door.GetComponent<AudioSource>().Play();
            Display.SetActive(true);

            Destroy(gameObject);

            collision.transform.Find("FloppyDiskMesh").gameObject.SetActive(true);
        }
    }
}
