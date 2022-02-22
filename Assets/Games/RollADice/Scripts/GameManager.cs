using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	#region Fields
	[Header("GameObjects")]
	[SerializeField] private GameObject diceGO;
	[SerializeField] private int numberOfAtttempts;

    public int NumberOfAtttempts { get => numberOfAtttempts; set => numberOfAtttempts = value; }
    #endregion

    #region Properties
    #endregion

    #region MonoBehaviour
    void Start()
	{

	}

	void Update()
	{

	}
	#endregion

	#region Methods
	public void RollDice()
    {
		diceGO.GetComponent<Dice>().RollDice();
	}
	#endregion
}
