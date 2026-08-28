using UnityEngine;

public class OutMap : MonoBehaviour
{
    void Start()
    {

    }

    void update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Player p = other.GetComponent<Player>();

        if(p == null)
            return;

        UIManeger.Instance.ShowNotiText($"You are Dead!!\nPoint: {p.Point}");
        Time.timeScale = 0f;
        
        UIManeger.Instance.ShowHideRestartButton(true);
    }
}
