using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
	#region Fields
	//[Header("")]
	[SerializeField] private int maxValue = 6;
	[SerializeField] private int currentValue = 1;
	[SerializeField] private Sprite[] valueSprites;
	[SerializeField] private SpriteRenderer spriteRenderer;
	[SerializeField] private GameManager gameManager;
	#endregion

	#region Properties
	#endregion

	#region MonoBehaviour
	void Start()
	{
		spriteRenderer.sprite = valueSprites[2];
	}


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
			RollDice();
		}
    }

    #endregion

    #region Methods
    private void SetSpriteBasedOnValue(int value)
    {
		spriteRenderer.sprite = valueSprites[value-1];
	}

	private void WinCondition()
    {
		Debug.Log("You won the game");
		// Reset number of attempts
		gameManager.NumberOfAtttempts = 0;
	}

	public void RollDice()
	{
		// Random.Range includes min but excludes max so incrementing maxvalue with one
		currentValue = Random.Range(1, maxValue+1);
		SetSpriteBasedOnValue(currentValue);
		// Check win condition
		if(currentValue == maxValue)
        {
			WinCondition();
		}
		else 
		{
			gameManager.NumberOfAtttempts++;
			Debug.Log("Rolled: " + currentValue  +  ". Attempt failed. Totalt attempts: " + gameManager.NumberOfAtttempts);
		}
	}
	#endregion
}
