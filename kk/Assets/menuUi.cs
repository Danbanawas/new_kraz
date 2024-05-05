using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class menuUi : MonoBehaviour
{
        public GameObject canvas;
        public InputActionProperty show;


        void Update()
        {
            if (show.action.WasPressedThisFrame())
            {

                canvas.SetActive(!canvas.activeSelf);

            }
        }
    }

