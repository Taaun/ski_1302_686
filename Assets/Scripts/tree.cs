using Unity.VisualScripting;
using UnityEngine;

public class tree : MonoBehaviour
{
    private MeshRenderer rd;
    void Start()
    {
        rd = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        rd.material.color = Color.red;

        Player player = collision.gameObject.GetComponent<Player>();
        if (player == null )
            return;

        player.Hp -= 15;
        UIManeger.Instance.ShowNotiText($"Hurt -15\nHP: {player.Hp}");

        if(player.Hp <= 0 )
        {
            UIManeger.Instance.ShowNotiText($"You are Dead!!\nPoint: {player.Point}");

            Time.timeScale = 0f;
            UIManeger.Instance.ShowHideRestartButton(true);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        rd.material.color = new Color32(91 ,44 ,22 ,255);
    }
}
