using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/* Helps NodeType GameObjects keep track of their various components
 * 
 * Makes accessing components on different nodes much easier
 * 
 */
namespace NodeInteractions
{
    public class Node : MonoBehaviour
    {
        public bool isHead;
        public bool hasData = false;

        public GameObject prev;
        public GameObject next;

        public TextMeshPro data;
        public TextMeshPro Tprev;
        public TextMeshPro Tnext;

        void Start()
        {
            //Tprev.SetText("NULL");
            //Tnext.SetText("NULL");
            //data.SetText("");
            isHead = false;
        }

        private void Update()
        {
            //Tprev.SetText("NULL");
            //Tnext.SetText("NULL");
            //data.SetText("");
        }

    }

}
