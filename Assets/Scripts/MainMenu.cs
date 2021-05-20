using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject parent;

    private void Start()
    {
        var bg = Resources.Load<GameObject>($"Prefabs/BG/BG{Random.Range(1, 7)}").transform;
        Instantiate(bg, new Vector3(0, 0, 90), Quaternion.identity).SetParent(parent.transform);
    }

    private void Update()
    {
    }
}