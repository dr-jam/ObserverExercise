using UnityEngine;

public class GenerateMinis : MonoBehaviour
{
    [SerializeField]
    private GameObject MiniPrefab;
    [SerializeField]
    private int MiniCount = 50;

    void Awake ()
    {
        for (int i = 0; i < this.MiniCount; i++)
        {
            Instantiate(this.MiniPrefab, this.gameObject.transform.position, Quaternion.identity);
        }
    }
} 
