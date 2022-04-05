﻿using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class TimerDelta : MonoBehaviour
    {
        private float waitTime = 2.0f;
        private float timer = 0.0f;
        private float visualTime = 0.0f;
        private int width, height;
        private float value = 10.0f;
        private float scrollBar = 1.0f;

        // Use this for initialization
        void Start()
        {
            width = Screen.width;
            height = Screen.height;
            Time.timeScale = scrollBar;
        }

        // Update is called once per frame
        void Update()
        {
            timer += Time.deltaTime;

            if(timer > waitTime)
            {
                visualTime = timer;
                timer -= waitTime;
                Time.timeScale = scrollBar;
            }
        }

        void OnGUI()
        {
            GUIStyle sliderDetails = new GUIStyle(GUI.skin.GetStyle("horizontalSlider"));
            GUIStyle sliderThumbDetails = new GUIStyle(GUI.skin.GetStyle("horizontalSliderThumb"));
            GUIStyle labelDetails = new GUIStyle(GUI.skin.GetStyle("label"));

            // Set the size of the fonts and the width/height of the slider.
            labelDetails.fontSize = 6 * (width / 200);
            sliderDetails.fixedHeight = height / 32;
            sliderDetails.fontSize = 12 * (width / 200);
            sliderThumbDetails.fixedHeight = height / 32;
            sliderThumbDetails.fixedWidth = width / 32;

            // Show the slider. Make the scale to be ten times bigger than the needed size.
            value = GUI.HorizontalSlider(new Rect(width / 8, height / 4, width - (4 * width / 8), height - (2 * height / 4)),
                value, 5.0f, 20.0f, sliderDetails, sliderThumbDetails);

            // Show the value from the slider. Make sure that 0.5, 0.6... 1.9, 2.0 are shown.
            float v = ((float)Mathf.RoundToInt(value)) / 10;
            GUI.Label(new Rect(width / 8, height / 3.25f, width - (2 * width / 8), height - (2 * height / 4)),
                "timeScale: " + v.ToString("f1"), labelDetails);
            scrollBar = v;

            // Display the recorded time in a certain size.
            labelDetails.fontSize = 14 * (width / 200);
            GUI.Label(new Rect(width / 8, height / 2, width - (2 * width / 8), height - (2 * height / 4)),
                "Timer value is: " + visualTime.ToString("f4") + " seconds.", labelDetails);
        }
    }
}