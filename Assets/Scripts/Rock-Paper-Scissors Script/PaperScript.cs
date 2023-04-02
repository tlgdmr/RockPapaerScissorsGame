using UnityEngine;

public class PaperScript : MonoBehaviour
{
    [SerializeField] GameObject scissorsPrefab;
    [SerializeField] GameObject canvas;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Scissors")
        {
            GameObject newScissors = Instantiate(scissorsPrefab, transform.position, Quaternion.identity);

            newScissors.transform.SetParent(canvas.transform);

            Destroy(gameObject);
        }
    }
}
