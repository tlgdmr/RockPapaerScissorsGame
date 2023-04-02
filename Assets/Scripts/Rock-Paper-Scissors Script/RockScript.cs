using UnityEngine;

public class RockScript : MonoBehaviour
{
    [SerializeField] GameObject paperPrefab;
    [SerializeField] GameObject canvas;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Paper")
        {
            GameObject newPaper = Instantiate(paperPrefab, transform.position, Quaternion.identity);

            newPaper.transform.SetParent(canvas.transform);

            Destroy(gameObject);
        }
    }
}
