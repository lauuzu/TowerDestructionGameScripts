using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventorius : MonoBehaviour {

	public class Stuff
	{
		public int bullets;
		public Stuff(int bul)
		{
			bullets = bul;
		}
		//konstruktorius
		public Stuff ()
		{
			bullets = 50;
		}
	}
	public Stuff Mystuff = new Stuff(60);

	void Start()
	{
		Debug.Log (Mystuff.bullets);
	}
	

}
