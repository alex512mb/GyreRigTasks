using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Task_1
{
    public class Controller : MonoBehaviour
    {
        [SerializeField] private Model model = default;
        [SerializeField] private View view = default;

        private void Awake()
        {
            view.OnButtonClicked += View_OnButtonClicked;
        }

        private void View_OnButtonClicked()
        {
            AddClick();
        }

        public void AddClick()
        {
            model.CountClicks++;
        }
    }
}

