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
    /// アイテム
    /// </summary>
    public class Item : MonoBehaviour 
    {
        [SerializeField]
        private Text header = null;

        [SerializeField]
        private Text title = null;

        [SerializeField]
        private Text duration = null;

        /// <summary>Mono Method</summary>
        void Start () 
        {
        
        }
        
        /// <summary>Mono Method</summary>
        void Update () 
        {
        
        }

        public void SetInformation(string header, string title, string duration)
        {
            this.header.text = header;
            this.title.text = title;
            this.duration.text = duration;
        }
    }
}
