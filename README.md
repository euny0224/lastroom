# LastRoom Adventure Game

This project contains a simple Unity script `AdventureGame.cs` that manages a short visual novel with **13 rooms** and **13 endings**. The script cycles through backgrounds when the player presses the **Space** key.

## How to Use

1. **Import the Script**
   - Copy `Assets/Scripts/AdventureGame.cs` into your Unity project's `Assets/Scripts/` folder.
   - Make sure the folder structure matches (`Assets/Scripts`).

2. **Create a GameObject**
   - In your Unity scene, create an empty GameObject and name it `GameManager` (or any name you prefer).
   - Add the `AdventureGame` component to this object via the **Inspector**.

3. **Set Up UI Elements**
   - Add a `Canvas` with an `Image` and an optional `Text` (legacy `UI/Text`) component.
   - Assign the `Image` component to `displayImage` in the `AdventureGame` script.
   - Optionally assign the `Text` component to `messageText` for ending messages.

4. **Assign Backgrounds**
   - Prepare 13 sprites for the rooms and 13 sprites for the endings.
   - In the Inspector for `AdventureGame`, populate the `roomBackgrounds` and `endingBackgrounds` arrays with these sprites.
   - Ensure the arrays are exactly 13 elements long, matching the script's expectations.

5. **Play the Game**
   - Enter Play mode in Unity.
   - Press **Space** to advance from each room to its ending and then to the next room. After the final ending, a "Thanks for playing!" message appears.

## Korean Instructions (한글 안내)

1. `Assets/Scripts/AdventureGame.cs` 파일을 자신의 프로젝트 `Assets/Scripts` 폴더에 복사합니다.
2. 빈 GameObject를 만들고 `AdventureGame` 컴포넌트를 추가합니다.
3. 캔버스에 Image와 Text(UI) 요소를 배치한 뒤, 각각 `displayImage`와 `messageText`로 연결합니다.
4. 13개의 방 배경 이미지와 13개의 엔딩 이미지를 차례대로 배열에 넣습니다.
5. 실행 후 **Space** 키를 누르면 방과 엔딩이 순차적으로 진행됩니다.

