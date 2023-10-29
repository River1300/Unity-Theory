﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity_Theory.GyungGi
{
    internal class _2WeeksVS
    {
        /*
        스크립트 머신

        비주얼 스크립팅의 기초.

        오브젝트에 그래프를 넣기 위해서 필요한 기본 컴포넌트를 말한다.

        스크립트 머신은 에셋을 만들지 않고 바로 작성 가능한 임베드 모드와 C# 스크립트처럼
        에셋으로 보관 가능한 그래프 모드가 있다.

        작동하게 되면 그래프에서 실시간으로 흐름을 볼 수 있으며 전달하는 데이터 또한
        바로 확인 가능하다.

        그래프의 흐름을 시각적으로 연결하여 로직을 만들 수 있다.
        */

        /*
        유연한 검색기

        빠르고 쉬운 검색.

        필요하 속성 혹은 함수를 호출하기 위해 클래스 이름까지 또박또박 적을 필요가 없다.

        관련된 몇 글자만 적어주면 그에 맞는 요소들을 빠르게 찾아서 표시해 준다.
        */

        /*
        자동 변환

        더욱 빠른 로직 작성을 도와주는 기능.

        노드에 필요한 컴포넌트를 오브젝트에서 자동으로 감지하고 가져온다.

        그렇기 때문에 꼭 타입을 맞추어 연결할 필요가 없다.

        하나의 오브젝트 안에서 동작하는 것은 아예 연결해줄 필요 없이 자동으로 인식한다.
        */

        /*
        예측 디버깅

        문제점을 미리 알려주는 가이드.

        로직을 실행할 때 문제가 될 만한 곳이 있다면 게임 실행 중이 아니더라도 그 즉시
        노란색으로 표기해 주면서 경고를 나타낸다.

        덕분에 버그를 잡기 위해 불필요한 반복 실행을 피할 수 있게 되었다.
        */

        /*
        라이브 에디팅
        
        실시간으로 편집하는 로직

        기존 C# 코드 스크립팅은 런타임을 먼저 종료하고 나서야 편집을 진행할 수 있는 반면,

        비주얼 스크립팅은 런타임 중에서도 그래프를 자유롭게 변경할 수 있다.

        그래서 실시간으로 게임 플레이어와 그래프를 확인하면서 빠르고 재밌는 컨텐츠 개발을 진행할 수 있다.
        */

        /*
        완벽한 코드 호환성

        무한한 확장성을 보장한다.

        유니티 엔진의 기본 라이브러리 뿐만 아니라 직접 만든 스크립트도 그래프로 녹아 들게 할 수 있다.

        그래프만으로 작성하기 어려운 복잡한 로직은 스크립트로 보완하여 복잡도를 줄일 수 있다.
        */

        /*
        중첩 및 재사용성

        두고두고 사용할 수 있는 그래프.

        범용성을 갖춘 그래프를 만들었다면 별다른 조작없이 다른 그래프에 바로 붙여서 활용할 수 있다.

        심지어 그래프들은 에셋 형태로 보관되어 있으므로 다른 개발자들과 공유도 가능하다.
        */

        /*
        상태 머신

        인공지능의 발판.

        인공지능 AI 를 체계적으로 구성할 수 있도록 상태 머신을 지원한다.

        상태가 바뀌는 방향과 조건을 편리하게 작성하고 런타임에서도 실시간 상태 변화를
        눈으로 직접 확인할 수 있어서 큰 규모의 AI 도 걱정 없다.
        */

        /*
        변수 저장 시스템

        다양한 타입 저장 지원.

        C# 코드 스크립팅에서는 변수가 있듯이 여기서도 변수 컴포넌트를 추가적으로 가지고 있다.

        흐름 > 그래프 > 오브젝트 > 장면 > 장면 > 앱 단위 별로 변수를 지정할 수 있으며,
        더 나아가 앱을 종료해도 디바이스에 남아 있는 저장 시스템도 지원한다.
        */

        /*
        그래프 인스펙터

        오브젝트의 정보를 확인할 수 있는 기본 인스펙터와 비슷한 비주얼 스크립팅 전용 인스펙터이다.

        그래프 창에 고정되어 있으며 상단의 버튼으로 숨길 수 있다.

        아무런 노드를 선택하지 않으면 그래프의 기본 정보를 편집할 수 있고,
        노드를 선택하면 해당 노드에 대한 정보와 기타 옵션들을 설정할 수 있다.
        */

        /*
        블랙보드

        그래프 내에서 활용하기 위한 변수들을 관리할 수 있는 창

        그래프 인스펙터와 마찬가지로 그래프 창에 고정되어 있고 상단 버튼으로 숨길 수 있다.
        */

        /*
        노드

        노드 구성: 아이콘, 노드 이름, 컴포넌트, 노드의 필요 데이터, 인풋, 아웃풋
        */

        /*
        이벤트

        비주얼 스크립트에서는 로직의 시작점은 이벤트이다.

        Event 메뉴로 들어가면 다양한 카테고리를 확인할 수 있으며 로직을 실행시켜야 할
        상황을 고려하여 알맞은 이벤트 노드를 선택한다.
        */

        /*
        쉽게 노드 찾기

        우 클릭 메뉴의 상단 검색창에서 원하는 노드의 이름을 검색

        다만 공들여 정확하게 입력할 필요 없이 중간중간 핵심 글자 몇 개만 입력하면
        알아서 Fuzzy Finder 가 알맞는 노드들을 보여 준다.
        */

        /*
        Rigidbody 2D: Add force( force, mode ) 노드로 물리적인 힘을 가하는 노드를 만든다.

        노드 연결

        코드 스크립팅에서 '함수' 와 같은 노드는 모두 흐름을 받는 연결부가 있다.

        이것을 실행시키기 위해서 이벤트에서 출발한 흐름을 연결해주어야 한다.

        연결부 화살표를 좌클릭한 후 다음 노드의 받는 연결부에서 다시 좌클릭하여 연결한다.

        흐름은 우클릭으로 다시 해제할 수 있다.

        On Button Input 노드를 만들고 Name:Jump 입력, Action:Down
        On Button Input -> Rigidbody 2D Add Force( Force:0, 40 )( Mode: Impulse )
        */

        /*
        그룹으로 묶기

        여러 노드를 사용하여 하나의 기능을 만들었다면 다른 기능의 그래프와 구분하기
        쉽도록 그룹으로 묶는 것이 여러모로 좋다.

        빈 공간에서 Ctrl + 좌클릭 드래그를 통해 원하는 노드들을 감싸주어 생성한다.

        상단 바에서 그룹 이름을 지정할 수 있으며 그래프 인스펙터에서 그룹 색상도 지정할 수 있다.
        */

        /*
        
        */
    }
}
