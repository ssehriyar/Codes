using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Interaction
{
    public class PlayerInteraction: MonoBehaviour
    {

        public Text scoreTable, timer;
        public string sec;
        string min;
        int score = 0;
        private float startTime;

        private void Start()
        {
            startTime = Time.time;
        }
        void Update()
        {
            float t = Time.timeSinceLevelLoad;
            sec = (t % 60).ToString("00");
            min = Mathf.Floor((int)t / 60).ToString("00");
            scoreTable.text = "Score: " + score;
            timer.text = min + ":" + sec;
        }
        void OnCollisionEnter2D(Collision2D col)
        {
            if (col.gameObject.tag == "pointTag")
            {
                Destroy(col.gameObject);
                score++;
            }
            if (col.gameObject.tag == "bugTag")
            {
                SceneManager.LoadScene(2);
                Destroy(gameObject);
            }
        }

    }
}
