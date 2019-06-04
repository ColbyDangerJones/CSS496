using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Valve.VR.InteractionSystem.Sample
{
    public class RestartScene : MonoBehaviour
    {
        public Scene scene;
        public HoverButton hoverButton;
        //public GameObject player;

        // Start is called before the first frame update
        void Start()
        {
            //DontDestroyOnLoad(player);
            hoverButton.onButtonDown.AddListener(OnButtonDown);
            //scene = SceneManager.GetActiveScene();
        }
        
        private void OnButtonDown(Hand hand)
        {
            SceneManager.LoadScene(0);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
