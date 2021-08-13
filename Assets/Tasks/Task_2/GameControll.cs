using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Task_2
{
    public class GameControll : MonoBehaviour
    {
        [SerializeField] MainScreen mainScreen = default;
        [SerializeField] Spawner spawner = default;

        private void Awake()
        {
            mainScreen.Setup(spawner.SpawnDeley, spawner.CubeSpeed, spawner.MaxDistance);
        }

        private void OnEnable()
        {
            mainScreen.OnSpawnDeleyChanged += MainScreen_OnSpawnDeleyChanged;
            mainScreen.OnCubeSpeedChanged += MainScreen_OnCubeSpeedChanged;
            mainScreen.OnMaxDistanceChanged += MainScreen_OnMaxDistanceChanged;
        }

        private void OnDisable()
        {
            mainScreen.OnSpawnDeleyChanged -= MainScreen_OnSpawnDeleyChanged;
            mainScreen.OnCubeSpeedChanged -= MainScreen_OnCubeSpeedChanged;
            mainScreen.OnMaxDistanceChanged -= MainScreen_OnMaxDistanceChanged;
        }

        private void MainScreen_OnMaxDistanceChanged(float value)
        {
            spawner.MaxDistance = value;
        }

        private void MainScreen_OnCubeSpeedChanged(float value)
        {
            spawner.CubeSpeed = value;
        }

        private void MainScreen_OnSpawnDeleyChanged(float value)
        {
            spawner.SpawnDeley = value;
        }
    }
}

