using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Example
{
    public class Timerbehavior : MonoBehaviour
    {

        [SerializeField]
        private float duration = 1f;
        [SerializeField]
        private UnityEvent onTimerEnd = null;

        private Timer timer;

        private void Start()
        {
            timer = new Timer(duration);

            timer.OnTimerEnd += HandleTimerEnd;
        }

        private void HandleTimerEnd()
        {
            onTimerEnd.Invoke();

            Destroy(this);
        }

        private void Update()
        {
            timer.Tick(Time.deltaTime);
        }
    }
}
