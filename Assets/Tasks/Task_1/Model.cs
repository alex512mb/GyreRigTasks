using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Task_1
{
    public class Model : MonoBehaviour
    {
        public event Action<int> OnCountClicksChanged;
        public int CountClicks 
        {
            get => countClicks;
            set
            {
                if (countClicks != value)
                {
                    countClicks = value;
                    OnCountClicksChanged?.Invoke(value);
                }
            }
             
        }
        private int countClicks;
    }
}

