using UnityEngine;

namespace SpaceDelivery.Environment
{
    public enum SpawnObjectTypes
    {
        Pizza,
        PieceOfPizza,
        Donut,
        Popcorn
    }

    public class SpawnObjects : MonoBehaviour
    {
        [SerializeField] SpawnObjectTypes spawnObjectType;

        void Start()
        {
            switch (spawnObjectType)
            {
                case SpawnObjectTypes.Pizza:
                    Instantiate(Resources.Load("Pizza") as GameObject, transform.position + Vector3.up,
                        Quaternion.identity, transform).name = $"{SpawnObjectTypes.Pizza}";
                    gameObject.name = SpawnObjectTypes.Pizza.ToString();
                    break;
                case SpawnObjectTypes.PieceOfPizza:
                    Instantiate(Resources.Load("PieceOfPizza") as GameObject, transform.position + Vector3.up,
                        Quaternion.identity, transform).name = $"{SpawnObjectTypes.PieceOfPizza}";
                    gameObject.name = SpawnObjectTypes.PieceOfPizza.ToString();
                    break;
                case SpawnObjectTypes.Donut:
                    Instantiate(Resources.Load("Donut") as GameObject, transform.position + Vector3.up,
                        Quaternion.identity, transform).name = $"{SpawnObjectTypes.Donut}";
                    gameObject.name = SpawnObjectTypes.PieceOfPizza.ToString();
                    break;
                case SpawnObjectTypes.Popcorn:
                    Instantiate(Resources.Load("Popcorn") as GameObject, transform.position + Vector3.up,
                        Quaternion.identity, transform).name = $"{SpawnObjectTypes.Popcorn}";
                    gameObject.name = SpawnObjectTypes.Donut.ToString();
                    break;
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawSphere(transform.position, 1);
        }
    }
}