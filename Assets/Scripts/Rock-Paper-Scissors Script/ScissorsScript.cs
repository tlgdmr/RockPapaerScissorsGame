using UnityEngine;

public class ScissorsScript : MonoBehaviour
{
    [SerializeField] GameObject rockPrefab;
    [SerializeField] GameObject canvas;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Rock")
        {
            GameObject newRock = Instantiate(rockPrefab, transform.position, Quaternion.identity);

            newRock.transform.SetParent(canvas.transform);

            Destroy(gameObject);
        }
    }
}
