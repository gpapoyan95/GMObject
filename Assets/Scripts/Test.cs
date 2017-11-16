using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class Test : GMViewController {

	public enum Orientation{ Left, Right, Top, Bottom }
	public Orientation orientation;
	public GMViewController ViewController2;
	
	public void closeViewController() {
		present(ViewController2, false);
	}

}
