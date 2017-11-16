using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMViewController : GMObject {

	public GameObject View;
	
	// Use this for initialization
	void Start () {
		viewDidLoad();	
	}

	private void viewDidLoad() {
		log("naskiner");
	}
	
	/*
	 *	Presenting view controller
	 */

	protected void present(GMViewController viewController, bool animated) {
		if(animated) {
			var animator = viewController.GetComponent<Animator>();
			if (animator != null) {
				dismissSelf();
				viewController.View.SetActive(true);
				animator.Play("present_animation_" + viewController.GetType().Name);
			} else {
				throw new System.ArgumentException("Parameter cannot be null", "animator");
			}
		} else {
			viewController.View.SetActive(true);
			dismissSelf();	
		}
		log(viewController.GetType().Name + " is Presented");
	}
	
	/*
	 *	Dismiss view controller
	 */
	
	public void dismiss(GMViewController viewController, bool animated) {
		viewController.View.SetActive(false);
	}
	
	/*
	 *	Is view controller presented
	 */

	public bool isViewControllerPresent() {
		return gameObject.activeInHierarchy;
	}
	
	/*
	 *	dismiss self
	 */
	
	public void dismissSelf() {
		View.SetActive(false);		
	}
}
