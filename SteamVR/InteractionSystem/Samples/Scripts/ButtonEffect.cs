﻿//======= Copyright (c) Valve Corporation, All rights reserved. ===============

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

namespace Valve.VR.InteractionSystem.Sample
{
    public class ButtonEffect : MonoBehaviour
    {
        public GameObject HoverButton;

        public void OnButtonDown(Hand fromHand)
        {
            ColorSelf(Color.green);
            fromHand.TriggerHapticPulse(1500);
        }

        public void OnButtonUp(Hand fromHand)
        {
            ColorSelf(Color.red);
        }


        private void ColorSelf(Color newColor)
        {
            Renderer[] renderers = this.GetComponentsInChildren<Renderer>();
            for (int rendererIndex = 0; rendererIndex < renderers.Length; rendererIndex++)
            {
                renderers[rendererIndex].material.color = newColor;
            }
        }
    }
}