using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity_Theory.Poong
{
    internal class Unity_Visual_Scripting
    {
        /*
        Unity Visual Scripting은 비주얼 프로그래밍 도구로, 유니티 엔진에서 게임 및 애플리케이션 개발을 위해 코드 작성 없이 비주얼 그래픽 환경에서 로직 및 기능을 구현할 수 있는 도구다. 
        Unity Visual Scripting은 다양한 기능을 제공하며, 게임 오브젝트의 동작, 상호작용, 이벤트 처리, 애니메이션, 사운드, 물리 효과 및 UI 구성과 같은 다양한 측면에 대한 비주얼 스크립트를 작성할 수 있다. 
        사용자가 그래픽 노드를 연결하고 구성함으로써 스크립트를 작성할 수 있으며, 이 노드 기반 접근 방식은 프로그래밍 언어의 코드를 대신한다.
        */

        /*
        State Machine 컴포넌트는 상태 머신(State Machine)을 사용하여 게임 오브젝트의 상태를 전환할 수 있습니다.
        상태 머신은 게임 오브젝트의 상태를 나타내는 노드와 노드 간의 전환을 나타내는 화살표로 구성된 그래프다. 
        각 노드는 게임 오브젝트의 특정 상태를 나타내며, 화살표는 게임 오브젝트가 한 상태에서 다른 상태로 전환되는 방법을 나타낸다.

        MasterManager 라는 빈 오브젝트 생성 -> Visual Scripting:State Machine 컴포넌트 추가 -> Graph:New -> 상태 노드 만들기
        */

        /*
        처음 대기 화면 진입하면 캐릭터를 활성화 시킨다.

        SetActive 노드를 생성하고 풍월량 캐릭터 오브젝트를 넣는다.

        On Enter State -> Game Object Set Active 로 연결

        대기 화면에 있는 버츄얼 카메라도 함께 활성화 시킬 필요가 있다.

        Game Object Set Active( 풍월량 ) -> Game Object Set Active( 버추얼 카메라 ) 로 연결

        반대로 채굴장에 잇는 풍월량 캐릭터를 비활성화

        위와 마찬가지로 채굴장 상태를 연결한 뒤 대기 화면과 채굴장을 연결
        */

        /*
        대기 화면에서 채굴장 화면으로 넘어가기 위해 이벤트를 만든다.

        Event:Input:On Input System Event Button( On Pressed ) -> 캐릭터 오브젝트 배정 -> Input Action:Enter

        대기 화면에 있는 오브젝트와 이벤트
        스크립트:WorldPlace
        트리거 함수를 만들어서 오브젝트 이름을 표시
        */

        /*
        채굴장에서 대기 화면으로 넘어가기 위해 On Trigger Stay 2D 노드 생성( Coroutine 체크 )
        Graph 에 Count 변수 추가
        Get Varialble 노드를 추가하여 Count를 받고
        Add 로 Count 를 더한다.
        Set Variable 로 Count를 비교하여 대기 화면으로 플레이어를 내보낸다.
        Greater or Equal -> if -> true/false

        옵션에서 비주얼 스크립팅에 스크립트 머신을 추가한다. 스테이스 머신을 추가한다. -> Regenerate Nodes
        -> Trigger Unity Event 추가, 마스터 매니저 오브젝트 등록 -> Name 에 World 입력
        */

        /*
        대기 화면과 채굴장에서 각각 풍월량 캐릭터와 카메라를 활성화/비활성화 하도록 변경
        On Enter State / On Exit State
        */

        /*
        채굴장에 있는 풍월량 캐릭터의 Sleeping Awake 모드를 바꿔준다. 플레이어는 항상 깨어 있어야 하므로 Never Sleep 모드로 지정
        */

        /*
        컨트롤 누를 상태에서 빈 공간에서 드래그를 하여 노드를 구릅화한다.
        */

        /*
        채굴장에서 대기 화면으로 넘어가기 위해서는 채굴장 입구에 일정시간 위치해 있어야 한다.
        이 때 채굴장의 플레이어 캐릭터는 채궁장 입구에 위치한 상태에서 비활성화 된다.
        그러다면 대기화면에서 다시 채굴장으로 진입할 때 플레이어 캐릭터를 재조정할 필요가 있다.

        Wait For Second -> Set Position
        Get Position -> Set Position
        */

        /*
        3D 환경의 사격장에 입장할 경우
        On Enter State -> Game Object Set Active( Main Camera ) off -> Game Object Set Active( 3D Camera ) on -> Game Object Set Active( Virtual Camera ) on
        On Exit State 는 반대로
        */
    }
}
