using UnityEngine;

namespace KID
{
    public class Player : MonoBehaviour
    {
        [Header("移動速度"), Range(0, 100)]
        public float speed = 10;

        private Animator ani;

        private void Start()
        {
            ani = GetComponent<Animator>();
        }

        private void Update()
        {
            Move();
        }

        /// <summary>
        /// 移動
        /// </summary>
        private void Move()
        {
            float v = Input.GetAxis("Vertical");
            float h = Input.GetAxis("Horizontal");

            transform.Translate(h * Time.deltaTime * speed, v * Time.deltaTime * speed, 0);
        }
    }
}
