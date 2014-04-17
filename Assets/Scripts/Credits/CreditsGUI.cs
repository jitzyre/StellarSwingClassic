using UnityEngine;
using System.Collections;

public class CreditsGUI : MonoBehaviour
{
	private Vector3 initialPosition;
	
	private const string credits = 	  "Credits\n\n"
									+ "2014 Pillowdrift LTD.\n"
									+ "Stellar Swing and all \n characters and artwork\n"
									+ "are trademarks of Pillowdrift LTD. \n"
									+ "\n"
									+ "Lead Programmer\n"
									+ "Caitlin Wilks\n"
									+ "\n"
									+ "Level Designer\n"
									+ "Jitesh Rawal\n"
									+ "\n"
									+ "Prototyper\n"
									+ "Richard Webster-Noble\n"
									+ "\n"
									+ "Programmer\n"
									+ "Grant Livingston\n"
									+ "\n"
									+ "Level Designer\n"
									+ "Jitesh Rawal\n"
									+ "\n"
									+ "Artwork\n"
									+ "Tom Duke\n"
									//+ "Tim Murray\n"
									//+ "http://timmurray.co.uk/ \n"
									+ "Joe Brammer\n"
									+ "http://www.joebrammer3d.com/ \n"
									+ "\n"
									+ "Sound\n"
									+ "Freesound.org\n"
									+ "Black Boe\n"
									+ "DJ Chronos\n"
									+ "sandyrb\n"
									+ "\n"
									+ "Stellar Swing OST by\n"
									+ "Campbell Logan\n"
									+ "\n"
									+ "Special Thanks\n"
									+ "CGP and CGMA Derby\n"
									+ "Daniel Taylor\n"
									+ "Marc Wilks\n"
									+ "That guy (you)\n"
									+ "\n \n"
									+ "Thanks for playing!\n\n"
									+ "www.pillowdrift.com";
	
	// rate of scrolling
	private const float rate = 0.1f;
	
	// Use this for initialization
	void Start()
	{
		initialPosition = transform.position;
		guiText.text = credits;
	}
	
	// Update is called once per frame
	void Update()
	{
		transform.Translate(0, rate * Time.deltaTime, 0);
		
		if (transform.position.y > 3.5f)
			transform.position = initialPosition;
		
		// tap to get to menu
		if (Input.GetMouseButton(0))
		{
			Loading.Load("Title");
		}
	}
}
