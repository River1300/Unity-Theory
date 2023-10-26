using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity_Theory.Poong
{
    internal class Dot_Tween
    {
        /*
        Dotween은 Unity에서 애니메이션을 구현하기 위한 유틸리티 라이브러리다.

        Dotween은 위치, 회전, 크기, 색상, 알파 값 등 다양한 속성을 부드럽게 변경할 수 있는 다양한 애니메이션을 제공한다.
        Dotween은 애니메이션을 시간 기반으로 제어하기 때문에, 프레임 레이트에 영향을 받지 않고 일관된 애니메이션을 구현할 수 있다. 
        또한, 간단하고 직관적인 API를 제공하여 개발자가 빠르게 애니메이션을 구현할 수 있도록 도와준다.

        트윈 애니메이션(Tweening): DOTween을 사용하면 속성의 시작 및 종료 값을 정의하고 해당 속성을 지정된 시간 동안 변경할 수 있다. 
        이로써 움직임, 회전, 크기 조절 등의 애니메이션을 쉽게 만들 수 있다.

        이징(Interpolation): DOTween은 다양한 이징 옵션을 지원하여 애니메이션의 부드러움을 제어할 수 있다. 
        선형, 고무, 엑스포넨셜 및 다른 이징 옵션을 사용할 수 있다.

        시퀀스(Sequence): 여러 애니메이션을 순차적으로 또는 병렬로 실행하는 시퀀스를 만들 수 있다. 
        이를 통해 복잡한 애니메이션 흐름을 정의할 수 있다.

        루프 및 리버스: DOTween은 애니메이션을 반복하거나 역방향으로 재생할 수 있도록 지원한다.

        콜백 및 리스너: 애니메이션의 특정 이벤트, 예를 들어 시작, 종료 또는 업데이트와 관련된 콜백 및 이벤트 리스너를 등록할 수 있다.

        UI 요소 애니메이션: DOTween은 Unity UI 요소(버튼, 텍스트, 이미지 등)에 애니메이션을 적용하는 데 특히 유용하다.

        경로 애니메이션: 게임 오브젝트를 움직이는 경로를 정의하고 따라가도록 하는 경로 애니메이션을 지원한다.

        물리적 이동과 상호작용: DOTween은 물리 시뮬레이션을 통한 움직임과 상호작용에 사용할 수 있다.

        플러그인 및 확장성: DOTween은 다양한 확장 플러그인 및 확장성을 제공하며, 사용자 지정 트윈, 이징 및 콜백을 작성할 수 있다.
        */

        /*
        DOTween의 Fade 기능은 트윈 애니메이션을 사용하여 객체의 투명도(알파 값)를 조절하는 데 사용된다.
        이를 통해 오브젝트의 페이드 인/아웃 효과를 구현할 수 있다.

        Fade -> Duration:10 -> Play
        Fade -> Delay:14.5 -> Duration:1.5 -> Play

        스크립트:SplashManager
            public void NextScene() SceneManager.LoadScene("Menu");
            -> On Complete등록 -> Play
        */

        /*
        DOTween의 LocalMove 기능은 트윈 애니메이션을 사용하여 객체를 로컬 공간에서 이동시키는 데 사용된다.
        LocalMove 기능을 사용하면 게임 오브젝트를 움직이거나, 회전하거나, 크기를 조절하는 등의 작업을 수행할 수 있다.

        LocalMove -> Ease:InOutQuad -> Relative -> To:y:-50 -> Loops:-1 -> Loop Type:Yoyo -> Play
        LocalMove -> Ease:OutQuad -> Relative -> To:x:0 -> Play
        LocalMove -> Ease:OutBack -> Duration:0.4
        */

        /*
        DOTween의 "Relative" 기능은 객체의 현재 위치나 상태를 기준으로 상대적인 변화를 적용하는 기능이다. 
        이것은 객체의 위치, 회전, 크기 또는 다른 속성을 현재 값에서 상대적으로 변화시킬 때 사용된다.

        x:500 이라고 할때 Relative 가 false일 경우 x 좌표 500 으로 이동
        Relative 가 true일 경우 현재 x 좌표에서 500 만큼 이동
        */
    }
}
