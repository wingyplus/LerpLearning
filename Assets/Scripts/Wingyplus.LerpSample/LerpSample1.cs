using Unity.Mathematics;
using UnityEngine;

namespace Wingyplus.LerpSample
{
    /// <summary>
    /// A simple color lerp with Unity mathematics.
    ///
    /// NOTE: You can use Mathf.Lerp which produce the same result as
    /// math.lerp does.
    /// </summary>
    public class LerpSample1 : MonoBehaviour
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
            _renderer.color = LerpColor(A, B, T.Value);
        }

        private static Color LerpColor(Color a, Color b, float t)
        {
            Color c;
            c.r = math.lerp(a.r, b.r, t);
            c.g = math.lerp(a.g, b.g, t);
            c.b = math.lerp(a.b, b.b, t);
            c.a = math.lerp(a.a, b.a, t);
            return c;
        }
    }
}