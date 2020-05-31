using UnityEngine;

namespace KID
{
    public class OrderByYAxis : MonoBehaviour
    {
        [Header("位移")]
        public float offset;

        private SpriteRenderer spr;

        private void Awake()
        {
            spr = GetComponent<SpriteRenderer>();
        }

        private void Update()
        {
            spr.sortingOrder = Mathf.RoundToInt((transform.position.y + offset) * -100);
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position + transform.up * offset, 0.1f);
        }
    }
}
