using System;
using UnityEngine;
using UnityEngine.UI;

namespace Wingyplus.LerpSample
{
    public class DispalyT : MonoBehaviour
    {
        public T T;
        private Text _text;

        private void Start()
        {
            _text = GetComponent<Text>();
        }

        private void Update()
        {
            _text.text = $"T = {T.Value}";
        }
    }
}