using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Task_2
{
    public class Spawner : MonoBehaviour
    {
        public float SpawnDeley { get => spawnDeley; set => spawnDeley = value; }
        public float CubeSpeed { get => cubeSpeed; set => cubeSpeed = value; }
        public float MaxDistance { get => maxDistance; set => maxDistance = value; }

        [SerializeField] private float spawnDeley = default;
        [SerializeField] private float cubeSpeed = default;
        [SerializeField] private float maxDistance = default;
        [SerializeField] private CubeControll cubePrefab = default;


        private IEnumerator Start()
        {
            while (true)
            {
                yield return new WaitForSeconds(SpawnDeley);
                Spawn();
            }
        }

        private void Spawn()
        {
            CubeControll cube = Instantiate(cubePrefab, transform.position, transform.rotation);
            cube.Speed = CubeSpeed;
            cube.MaxDistance = MaxDistance;
        }
    }
}
