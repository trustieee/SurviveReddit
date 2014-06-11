using UnityEngine;
using System.Collections;

public class ItemShop : MonoBehaviour {

	public bool mShowShop;
	private GameObject mPlayer;
	private Inventory mInventory;
	private PlayerController mPcontroller;

	void Start() {

		mPlayer = GameObject.FindGameObjectWithTag ("Player");
		mInventory = mPlayer.GetComponent<Inventory> ();
		mPcontroller = mPlayer.GetComponent<PlayerController> ();

	}

	void Update () {

				if (Input.GetButtonUp ("Shop")) {

						mShowShop = !mShowShop;

				}
		}

	void OnGUI () {

		if (mShowShop) {

						GUI.Box (new Rect ((Screen.width / 2) - 45, (Screen.height / 2) - 45, 100, 90), "Item Shop");
		
						if (GUI.Button (new Rect ((Screen.width / 2) - 35, (Screen.height / 2) - 20, 80, 20), "Buy Ammo")) {
								
							if (mPcontroller.Dollars >= 150 && !mInventory.InventoryFilled()){

									mPcontroller.Dollars -= 150;
									mInventory.AddItem(4, 50);

							}

						}
		
						// Make the second button.
						if (GUI.Button (new Rect ((Screen.width / 2) - 35, (Screen.height / 2) + 10, 80, 20), "Buy Wood")) {
								
							if (mPcontroller.Dollars >= 100 && !mInventory.InventoryFilled()){
					
									mPcontroller.Dollars -= 100;
									mInventory.AddItem(6, 0);
					
								}

						}
				}
	}
}
