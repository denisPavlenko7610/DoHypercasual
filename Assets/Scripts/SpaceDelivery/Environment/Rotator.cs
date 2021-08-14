using DG.Tweening;
using UnityEngine;

namespace SpaceDelivery.Environment
{
    public class Rotator : MonoBehaviour
    {
        [SerializeField] float timeToRotate;
        void Start()
        {
            transform.DORotate(Vector3.up * 360f, timeToRotate, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart)
                .SetEase(Ease.Linear);
        }
    }
}