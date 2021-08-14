using System;
using SpaceDelivery.UI;
using UnityEngine;

namespace SpaceDelivery.Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerScore playerScore;
        [SerializeField] private PlayerStatus playerStatus;

        private float _minDistanceToFail = -15f;

        private void OnValidate()
        {
            if (playerScore == null)
            {
                playerScore = FindObjectOfType<PlayerScore>();
            }

            if (playerStatus == null)
            {
                playerStatus = FindObjectOfType<PlayerStatus>();
            }
        }

        public void Init()
        {
            
        }

        private void Update()
        {
            CheckFail();
        }

        public void SetWin()
        {
            Time.timeScale = 0;
            playerScore.DisableScore();
            playerStatus.SetWin();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Food"))
            {
                other.gameObject.SetActive(false);
                playerScore.UpdateScore();
            }
        }
        private void CheckFail()
        {
            if (transform.position.y < _minDistanceToFail)
            {
                playerStatus.SetFail();
                playerScore.DisableScore();
            }
        }

    }
}
