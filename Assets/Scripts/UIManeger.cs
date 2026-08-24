using UnityEngine;
using TMPro;

public class UIManeger : MonoBehaviour
{
    [SerializeField]
    private TMP_Text NotiText;
    public static UIManeger Instance;

    void Awake()
    {
        Instance = this;
    }
    void Start()
    {

    }

    void Update()
    {

    }

    public void ShowNotiText(string s)
    {
        NotiText.text = s;
    }
}
