using Unity.Mathematics;
using UnityEngine;

namespace Wingyplus.LerpSample
{
    /// <summary>
    /// It's produce the result as <see cref="LerpSample1"/>.
    /// </summary>
    public class LerpSample3 : MonoBehaviour
    {
        public Color A;
        public Color B;
        public T T;

        private SpriteRenderer _renderer;

        private void Start()
        {
            _renderer = GetComponent<SpriteRenderer>();
        }

        // Update is called once per frame
        private void Update()
        {
            _renderer.color = Color.Lerp(A, B, T.Value);
        }
    }
}