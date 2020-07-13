using System;
using UnityEngine;

namespace Wingyplus.LerpSample
{
    /// <summary>
    /// Lerp on material.
    /// </summary>
    public class LerpSample2 : MonoBehaviour
    {
        public Material A;
        public Material B;
        public T T;

        private SpriteRenderer _renderer;

        private void Start()
        {
            _renderer = GetComponent<SpriteRenderer>();
        }

        private void Update()
        {
            _renderer.material.Lerp(A, B, T.Value);
        }
    }
}