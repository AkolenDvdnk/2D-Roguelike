using UnityEngine;

public class Wall : MonoBehaviour
{
    public Sprite dmgSprite;
    public int hp = 4;

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void DamageWall(int value)
    {
        spriteRenderer.sprite = dmgSprite;
        hp -= value;

        if (hp <= 0)
            gameObject.SetActive(false);
    }
}
