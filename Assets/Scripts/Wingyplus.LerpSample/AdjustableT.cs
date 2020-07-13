using System;
using UnityEngine;

namespace Wingyplus.LerpSample
{
    public class AdjustableT : MonoBehaviour
    {
        public T T;
        [Range(0, 1)] public float Value;

        private void Update()
        {
            T.Value = Value;
        }
    }
}