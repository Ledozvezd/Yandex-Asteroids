using System;
using UnityEngine;

public class ShipPresenter : Presenter
{
    private Root _init;
    private int _lives = 3;

    public event Action<int> HealthChanged;
    public int Lives => _lives;
    public void Init(Root init)
    {
        _init = init;
        HealthChanged?.Invoke(_lives);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            _lives--;
            HealthChanged?.Invoke(_lives);
            if (_lives <= 0)
            {
                _init.EnableScreen();
                _init.DisableShip();
                
            }
        }
    }
   
}