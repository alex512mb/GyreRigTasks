using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Task_1
{
    public class View : MonoBehaviour
    {
        [SerializeField] private Text textCounterClicks = default;
        [SerializeField] private Button button = default;
        [SerializeField] private Model model = default;

        public event Action OnButtonClicked;


        private void Awake()
        {
            button.onClick.AddListener(() => OnButtonClicked?.Invoke());
            model.OnCountClicksChanged += Model_OnCountClicksChanged;
        }

        private void Start()
        {
            UpdateCountClicks();
        }

        private void Model_OnCountClicksChanged(int countClicks)
        {
            UpdateCountClicks();
        }

        private void UpdateCountClicks()
        {
            textCounterClicks.text = model.CountClicks.ToString();
        }
    }
}

