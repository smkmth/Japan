using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System.Collections;


//routeinfomation : list of all game areas in a dictionary 
//with descriptions 
//getrouteinfo: infomation extraction function, interogating
//the destinations and displaying the texts in the prompts
//cannavigate: test to see if navigation is possible 
//navigate: function to instiagte navigation 
//the script itself is a static class, so it sits in the background
//of the scene and exicutes itself.
public struct Route
{
	public string RouteDescription;
	public bool CanTravel;


}

//public Transform TargetPlayerLocation;

public static class NavigationManager
{

	public static Dictionary<string, Route> RouteInformation =
		new Dictionary<string,Route>()
	{
		{"TestRoom", new Route { RouteDescription = "the big bad world", CanTravel = true}
		},
		{"Cave", new Route { RouteDescription = "The deep dark cave", CanTravel = true}
		},
	};

	public static string GetRouteInfo(string destination)
	{
		return RouteInformation.ContainsKey(destination) ?
			//shorthand operator for else 
			RouteInformation[destination].RouteDescription : null;

	}

	public static bool CanNavigate(string destination)
	{
		return RouteInformation.ContainsKey(destination) ?
			RouteInformation[destination].CanTravel 
				: false;
	}

	//public static Transform TargetPlayerLocation;

	public static void NavigateTo( string destination)
	{
		
		//GameControl.Instance.TransitionTarget.position = TargetPlayerLocation.position;



		SceneManager.LoadScene (destination);
		
	
		//GameControl.Instance.FireSaveEvent ();

	}

}



	