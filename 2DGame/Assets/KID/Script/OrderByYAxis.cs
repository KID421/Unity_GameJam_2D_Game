using UnityEngine;

namespace KID
{
    public class OrderByYAxis : MonoBehaviour
    {
        [Header("位移 - 建議讓紅點調整到角色腳底下")]
        public float offset;
        [Header("是否為會移動的物件")]
        public bool isMoveObject;

        /// <summary>
        /// 圖片渲染元件
        /// </summary>
        private SpriteRenderer spr;

        private void Awake()
        {
            // 圖片渲染元件 = 取得元件<圖片渲染元件>();
            spr = GetComponent<SpriteRenderer>();

            // 更新順序
            UpdateOrder();
        }

        private void Update()
        {
            // 如果為不回移動的物件就跳出，降低效能消耗
            if (!isMoveObject) return;

            UpdateOrder();
        }

        /// <summary>
        /// 更新圖片順序
        /// </summary>
        private void UpdateOrder()
        {
            // 更新圖片.順序 = 數學.去小數點轉整數(角色 Y 軸 + 位移量 * -100 單位 + 5000)
            // + 5000 避免跑到背景後面
            spr.sortingOrder = Mathf.RoundToInt((transform.position.y + offset) * -100) + 5000;
        }

        /// <summary>
        /// 這是用來畫出中心點位移後的位置~
        /// 繪製 Unity 編輯器圖示
        /// </summary>
        private void OnDrawGizmos()
        {
            // 紅色
            Gizmos.color = Color.red;
            // 繪製圓形(繪製中心點，半徑)
            Gizmos.DrawWireSphere(transform.position + transform.up * offset, 0.1f);
        }
    }
}
