# LastRoom

Unity 기반의 간단한 어드벤처 게임 프로젝트입니다.

## 적용 방법

1. Unity Hub에서 "Add" 버튼을 눌러 이 저장소의 폴더를 선택합니다.
2. 프로젝트를 Unity 에디터에서 열고 `SampleScene`을 실행합니다.
3. 스페이스바를 눌러 각 방의 결말 화면을 확인하세요.

이미지 리소스와 스크립트는 `Assets/` 폴더에 포함되어 있으므로 별도의 설정 없이 바로 실행할 수 있습니다.

## AdventureGame 스크립트 사용법

1. 빈 GameObject를 만들고 `AdventureGame` 스크립트를 추가합니다.
2. Inspector에서 **Display Image** 필드에 화면에 보여줄 `Image` 컴포넌트를 할당합니다.
3. **Message Text** 필드에는 엔딩 메시지를 표시할 `Text` 컴포넌트를 연결합니다.
4. **Room Backgrounds**와 **Ending Backgrounds** 배열에 각각 13개의 스프라이트를 순서대로 넣어주세요.
5. 플레이 모드에서 스페이스바를 누르면 방과 결말 이미지가 차례대로 표시됩니다.

