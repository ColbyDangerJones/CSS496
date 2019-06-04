using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem.Sample
{
    public class DetachObject : MonoBehaviour
    {
        public Hand hand;
        public Component toDetach;

        void DestroyGameObject()
        {
            Destroy(gameObject);
        }

        // Update is called once per frame
        void Update()
        {
            if (hand.currentAttachedObject.tag == "PointerType")
            {
                DestroyComponent(hand.currentAttachedObject.GetComponent<FixedJoint>());
            }
        }

        void DestroyComponent(FixedJoint fixedJoint)
        {
            Destroy(GetComponent<FixedJoint>());
        }
    }
}
