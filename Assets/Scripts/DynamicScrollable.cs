using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;

/// <summary>
/// 実験用
/// </summary>
namespace SaitamaGames.Sandbox
{
    /// <summary>
    /// スクロールするかどうかを動的に決定する
    /// </summary>
    [RequireComponent(typeof(ScrollRect))]
    public class DynamicScrollable : MonoBehaviour
    {
        /// <summary>本体</summary>
        private ScrollRect scrollRect;
        private ScrollRect ScrollRect { get { return this.scrollRect ?? (this.scrollRect = GetComponent<ScrollRect>()); } }

        /// <summary>Mono function</summary>
        IEnumerator Start()
        {
            // データ構築まで1フレーム待つ（最初のフレームはすべて0になっている模様）
            yield return null;
            // ビューポートより中身のほうが大きいときのみ有効にし、そうでないときは無効にする
            this.ScrollRect.vertical = (this.ScrollRect.content.rect.height > this.ScrollRect.viewport.rect.height);
            this.ScrollRect.horizontal = (this.ScrollRect.content.rect.width > this.ScrollRect.viewport.rect.width);
        }

    }
}
