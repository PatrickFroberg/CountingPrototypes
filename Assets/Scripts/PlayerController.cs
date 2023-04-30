using UnityEngine;

namespace Assets.Scripts
{
    [RequireComponent(typeof(PlayerInput))]
    public class PlayerController : MonoBehaviour
    {
        public float MoveSpeed = 100f;
        //public float MoveSpeed = 150f;
        public float MoveBoundary = 18f;

        public void Move(float input)
        {
            transform.Translate(Vector3.forward * input * MoveSpeed * Time.deltaTime);

            float clampedY = Mathf.Clamp(transform.position.z, -MoveBoundary, MoveBoundary);
            transform.position = new Vector3(transform.position.x, transform.position.y, clampedY);
        }
    }
}
