using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour {

	protected static T mInstance;

	public static T Instance
	{
		get
		{
			if( mInstance == null )
			{
				mInstance = (T)FindObjectOfType( typeof( T ) );

				if( mInstance == null )
				{
					Debug.LogError( "An instance of " + typeof( T ) + " is needed in the scene, but there is none." );
				}
			}

			return mInstance;
		}
	}
}
