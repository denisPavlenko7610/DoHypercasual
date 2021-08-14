using System;
using UnityEngine;

namespace SpaceDelivery.Core
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private Player.Player player;

        private void OnValidate()
        {
            if (player == null)
            {
                player = FindObjectOfType<Player.Player>();
            }
        }

        void Start()
        {
            player.Init();
        }

        void Update()
        {
        
        }
    }
}
