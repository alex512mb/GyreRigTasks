using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

namespace Task_2
{
    public class MainScreen : MonoBehaviour
    {
        [SerializeField] private InputField inputFieldSpawnDeley = default;
        [SerializeField] private InputField inputFieldCubeSpeed = default;
        [SerializeField] private InputField inputFieldMaxDistance = default;


        public event Action<float> OnSpawnDeleyChanged;
        public event Action<float> OnCubeSpeedChanged;
        public event Action<float> OnMaxDistanceChanged;


        private void Awake()
        {
            inputFieldSpawnDeley.onValueChanged.AddListener(SpawnDeleyChangeHandler);
            inputFieldCubeSpeed.onValueChanged.AddListener(CubeSpeedChangeHandler);
            inputFieldMaxDistance.onValueChanged.AddListener(MaxDistanceChangeHandler);
        }

        private void SpawnDeleyChangeHandler(string strValue)
        {
            //string stringVal = "0.0";
            //float floatVal = float.Parse(strValue, CultureInfo.InvariantCulture.NumberFormat);
            //if (float.TryParse(strValue, out float result))
            //{
            //    OnSpawnDeleyChanged?.Invoke(result);
            //}
            //else
            //{
            //    Debug.LogError($"not parsed {strValue}");
            //}
            
            float value = float.Parse(strValue, CultureInfo.InvariantCulture.NumberFormat);
            OnSpawnDeleyChanged?.Invoke(value);
        }

        private void CubeSpeedChangeHandler(string strValue)
        {
            float value = float.Parse(strValue);
            OnCubeSpeedChanged?.Invoke(value);
        }

        private void MaxDistanceChangeHandler(string strValue)
        {
            float value = float.Parse(strValue);
            OnMaxDistanceChanged?.Invoke(value);
        }

        public void Setup(float spawnDeley, float cubeSpeed, float maxDistance)
        {
            inputFieldSpawnDeley.text = spawnDeley.ToString();
            inputFieldCubeSpeed.text = cubeSpeed.ToString();
            inputFieldMaxDistance.text = maxDistance.ToString();
        }
    }
}
