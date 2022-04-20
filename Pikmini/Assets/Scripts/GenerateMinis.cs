using UnityEngine;

public class GenerateMinis : MonoBehaviour
{
    [SerializeField]
    private GameObject miniPrefab;
    [SerializeField]
    private int miniCount = 50;

    void Awake ()
    {
        for (int i = 0; i < this.miniCount; i++)
        {
            Instantiate(this.miniPrefab, this.gameObject.transform.position, Quaternion.identity);
            FindObjectOfType<SoundManager>().PlaySoundEffect("NewMini");
        }
    }
} 
