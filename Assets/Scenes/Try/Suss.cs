using UnityEngine;
namespace Scenes
{
    public class Suss : MonoBehaviour
    {
        public Transform endPosition;
        public float lerpDuration = 1.0f;

        private float t = 0.0f;
        [SerializeField] private Vector3 startPosition;

        void Start()
        {
            startPosition = transform.position;
        }

        // void Update()
        // {
        //     t += Time.deltaTime / lerpDuration;
        //     t = Mathf.Clamp01(t);
        //     var y = Mathf.Lerp(startPosition.y, endPosition.position.y, t);
        //     //Vector3 interpolatedPosition = Vector3.Lerp(startPosition, endPosition.position, t);
        //     transform.position = new Vector3(transform.position.x, y, transform.position.z);
        //
        //     if (t >= 1.0f)
        //     {
        //         // t = 0.0f;
        //         //startPosition.y = transform.position.y;
        //     }
        // }
        
    }
}