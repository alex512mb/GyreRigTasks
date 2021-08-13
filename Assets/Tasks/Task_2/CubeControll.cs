using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Task_2
{
    public class CubeControll : MonoBehaviour
    {
        public float Speed { get => speed; set => speed = value; }
        public float MaxDistance { get => maxDistance; set => maxDistance = value; }


        [SerializeField] private float speed = default;
        [SerializeField] private float maxDistance = default;

        private Vector3 awakenPos;

        private void Awake()
        {
            awakenPos = transform.position;
        }

        private void Update()
        {
            transform.Translate(transform.forward * Speed * Time.deltaTime);
            float distancePassed = Vector3.Distance(awakenPos, transform.position);

            if (distancePassed >= MaxDistance)
            {
                Destroy(gameObject);
            }
        }

    }
}