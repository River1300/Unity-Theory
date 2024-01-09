using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity_Theory.UndeadSurvivor
{
    internal class Player
    {
        /*
        플레이어의 이미지 스프라이트를 스프라이트 에디터에서 잘라준다.
        아틀라스에서 자른 스프라이트를 확인하고 스프라이트를 씬에 배치한다.

        먼저 플레이어에게 물리적인 이동 기능을 추가한다.
            리지드바디 + 캡슐 콜라이더 컴포넌트를 추가한다.
                이때 플레이어는 상하좌우로 움직일 예정이므로 중력 값을 0으로 지정한다.
        플레이어의 자식으로 그림자 스프라이트를 추가한 뒤 OrderInLayer를 맞추어 준다.

        [플레이어가 사용자의 입력에 맞추어 이동] -> [사용자의 입력을 받을 변수가 필요]
        public Vector2 inputVec;
        inputVec.x 가 수평값을 받는다. ( GetAxis )
        inputVec.y 가 수직값을 받는다.

        [플레이어가 물리적으로 이동] -> [물리적인 힘을 사용자 입력에 맞추어 적용]
        Rigidbody2D rigid;
        rigid.MovePosition(rigid.position + inputVec);

        [사용자 컴퓨터 성능과 관계없이 캐릭터 속력을 동일하게 맞추어야] -> [방향 * 속도 * 시간(DeltaTimte)]
        Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime;
        public float speed 속성을 새로 갖는다.
        rigid.MovePosition(rigid.position + nextVec);

        [플레이어가 미끄러지듯 움직이면 안됨] -> [GetAxis로 받던 입력값을 GetAxisRaw로 받아서 가속도를 없]

        rigid.MovePosition(rigid.position + nextVec)은 현재 위치에 이동량(nextVec)을 더한 값을 MovePosition 함수의 인자로 전달한다.
        이렇게 하면 현재 위치를 기준으로 움직인다.

        MovePosition 함수는 Rigidbody2D의 위치를 부드럽게 이동시키는 함수이다.
        하지만 이 함수는 transform.position과는 다르게 Rigidbody2D의 위치를 직접 수정하는 것이 아니라 Rigidbody2D의 물리 시뮬레이션에 의해 자연스럽게 이송시키낟.

        따라서 rigid.position + nextVec는 현재 위치에서 이동량 nextVec을 더한 최종 위치를 계산하고, 이 위치로 Rigidbody2D를 부드럽게 이동시키는 역활을 한다.
        이렇게 하는 이유는 물리 엔진의 움직임을 통제하고 충돌을 정확하게 처리하기 위함이다.
        만약 Rigidbody2D의 position을 직접 수정하면 물리 시뮬레이션이 올바르게 작동하지 않을 수 있다.
        따라서 MovePosition 함수를 사용하여 물리 시뮬레이션과 Rigidbody2D의 위치를 동기화 한다.
         */
        public float speed;
        Vector2 inputVec;
        Rigidbody2D rigid;

        void Awake()
        {
            rigid = GetComponent<Rigidbody2D>();
        }

        void FixedUpdate()
        {
            Vector2 nextVec = inputVec * speed * Time.fixedDeltaTime;

            rigid.MovePosition(rigid.position + nextVec);
        }
        /*
        Input Manager 사용
        [패키지 다운로드] -> [새로운 액션 생성]
        스크립트에 적용하기 위해서는 반드시 UnityEngine.InputSystem 네임스페이스를 추가해 주어야 한다.

        value.Get<Vector2>()는 InputSystem에서 입력 값을 가져오는 메서드

        OnMove(InputValue value) 메서드는 InputSystem의 이벤트로서, 
        플레이어의 이동 입력을 감지하는 역할을 합니다. 
        이벤트가 발생할 때, InputSystem은 플레이어가 움직이는 방향을 Vector2 형태로 value 매개변수에 담아서 호출
        value.Get<Vector2>()는 이렇게 전달된 Vector2 값을 실제로 가져와서 사용

        예를 들어, 플레이어가 화살표 키를 누르면 value.Get<Vector2>()는 (1, 0) 또는 (-1, 0)과 같은 
        Vector2 값을 반환하여 플레이어의 움직임 방향을 알려준다.
        이 방향 값을 이용하여 플레이어를 이동시키거나, 
        특정 방향으로 공격을 발사하는 등의 동작을 수행한다.
         */

        /*
        2D 스프라이트 이미지가 움직이는 방향에 따라서 반전되어야 함
        [사용자의 방향키 입력을 받음] -> [x 방향으로 -,0,+ 를 확인] -> [반전]
        만약에 inputVec.x 값이 0이 아닐 경우 스프라이트를 반전 시키도록 한다.
         */
        void LateUpdate()
        {
            if (inputVec.x != 0) spriter.flipX = inputVec.x < 0;
            anim.SetFloat("Speed", inputVec.magnitude);
        }
        /*
        셀 애니메이션 등록
        애니메이터 컨트롤러를 만들고 씬에 배치된 플레이어 이미지에 스프라이트를 애니메이션 단위로 등록
        애니메이터 컨트롤러로 가서 트랜지션을 연결하고 파라미터를 추가한다.
        움직임에 따라서 파라미터에 로직을 연결

        Animator Override Controller 를 통해서 다른 캐릭터들에게 각각 똑같은 애니메이션을 연결해 준다.

        Animator Override Controller(애니메이터 오버라이드 컨트롤러)는 Unity의 Animator 
        컴포넌트에서 사용되는 스크립트 기반의 오버라이딩 시스템이다. 
        이 컨트롤러는 기존에 Animator 컴포넌트에 연결된 Animator Controller의 일부 애니메이션 클립을 
        런타임에 다른 애니메이션 클립으로 바꾸는 데 사용된다.

        주로 캐릭터나 적 캐릭터 등에 사용자 정의 애니메이션을 적용할 때 유용 
        예를 들어, 여러 캐릭터에 같은 Animator Controller를 사용하되, 
        캐릭터마다 다른 애니메이션을 적용하고 싶을 때 Animator Override Controller를 사용한다.
         */