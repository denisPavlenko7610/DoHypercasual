using System;
using UnityEngine;

namespace SpaceDelivery.Environment
{
    public class Finish : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                other.GetComponent<Player.Player>().SetWin();
            }
        }
    }
}
