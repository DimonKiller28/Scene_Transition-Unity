Как сделать своё меню загрузки?

Видео гайд: https://

1. Создаём Canvas.
2. Внутри Canvas создаём пустой объект, называем "Scene Transition", на него добавляем компонент Animator и Scene Transition.
3. Внутри объекта Scene Transition создаём Image называем его Image Fade. В компоненте Image в параметре Raycast Target убираем галочку. Параметрах Source Image и Color устанавлтваем значения по вашему желанию.
4. Внутри объекта Scene Transition создаём пустой объект Loading Block.
5. Внутри объекта Loading Block создаём текстовое поле, назовём его "Text Loading Precent". Добавляем его в компонент Scene Transition. В нём будет отображаться процент загрузки.
6. Внутри объекта Loading Block создаём Image, назовём его "Pogress Bar". Добавляем его в компонент Scene Transition. В компоненте Image в параметре Raycast Target убираем галочку, в параметре Image Type выбераем Filled, у дригих параметров устанавлтваем значения по желанию.
7. Создаём аниматор контроллер для объекта Scene Transition, добавляем его компонент в Animator.
8. Создаём 2 анимации: появления меню загрузки (Scene Closing); накрытие меню загрузки (Scene Opening).
9. Добавляем созданные анимации в аниматор контроллер:
	Parameters:
	sceneClosing - Trigger
	sceneOpening - Trigger
			
			Scene Closing
				↓↑			(↑ - sceneClosing, ↓ - Hes Exit Time ✓)
	Entry → New State
				↓↑			(↑ - Hes Exit Time ✓, ↓ - sceneOpening)
			Scene Closing
.
