using UnityEngine;

public class ShipPresenter : Presenter
{
    private Root _init;
    public uint Lives = 3;

    public void Init(Root init)
    {
        _init = init;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (Lives < 1)
            {
                _init.DisableShip();
            }
            else 
            {
                Lives--;
            }
        }
    }
   
}