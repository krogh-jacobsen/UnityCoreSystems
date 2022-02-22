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
	#endregion

	#region Methods
	private void SetSpriteBasedOnValue(int value)
    {
		spriteRenderer.sprite = valueSprites[value-1];
	}
	public void RollDice()
	{
		currentValue = Random.Range(1, maxValue);
		SetSpriteBasedOnValue(currentValue);
		// Check win condition
		if(currentValue == maxValue)
        {
			Debug.Log("You won the game");
			// Reset number of attempts
			gameManager.NumberOfAtttempts = 0;
		}
		{
			gameManager.NumberOfAtttempts++;
			Debug.Log("Rolled: " + currentValue  +  ". Attempt failed. Totalt attempts: " + gameManager.NumberOfAtttempts);
		}
	}
	#endregion
}
