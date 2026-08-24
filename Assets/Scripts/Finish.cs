using Unity.VisualScripting;
using UnityEngine;

public class Finish : MonoBehaviour
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

        UIManeger.Instance.ShowNotiText($"You Win!!\nPoint: {p.Point}");
    }
}
