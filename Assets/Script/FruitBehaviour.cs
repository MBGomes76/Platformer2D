using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class FruitBehaviour : MonoBehaviour
{
    public GameObject CollectedPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.AddFruit();
            Destroy(gameObject);
            Instantiate(CollectedPrefab, transform.position, Quaternion.identity);
        }
    }
}
