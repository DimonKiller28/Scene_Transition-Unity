How to make your own loading menu?

Video guide: https://

1. Create a Canvas.
2. Inside the Canvas, create an empty object, call it "Scene Transition", add the Animator component and Scene Transition to it.
3. Inside the Scene Transition object, create an Image, call it Image Fade. In the Image component, uncheck the Raycast Target parameter. Set the Source Image and Color parameters to your liking.
4. Inside the Scene Transition object, create an empty Loading Block object.
5. Inside the Loading Block object, create a text field, call it "Text Loading Precent". Add it to the Scene Transition component. It will display the loading percentage.
6. Inside the Loading Block object, create an Image, call it "Pogress Bar". Add it to the Scene Transition component. In the Image component, in the Raycast Target parameter, uncheck the box, in the Image Type parameter, select Filled, and set the other parameters to desired values.
7. Create an animator controller for the Scene Transition object, add its component to Animator.
8. Create 2 animations: opening the loading menu (Scene Closing); closing the loading menu (Scene Opening).
9. Add the created animations to the animator controller:
	Parameters:
	sceneClosing - Trigger
	sceneOpening - Trigger

			Scene Closing
				↓↑		(↑ - sceneClosing, ↓ - Hes Exit Time ✓)
	Entry → New State
				↓↑		(↑ - Hes Exit Time ✓, ↓ - sceneOpening)
			Scene Closing
.
