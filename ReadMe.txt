
1. SPA 구조, router
    1) LayoutComponentBase : 베이스 페이지 
    2) 내부의 @Body는 내부에 RenderFragment로 되어 있음
    3) RenderFragment : HTML 뭉텅이를 보내는것?
    4) @layout 레이아웃명 :  레이아웃을 해당 페이지만 바꾸고 싶을때 사용
    5) DefaultLayout : app에서 레이아웃을 바꾸면 기본 레이아웃이 바뀜
    6) _Imports.razor : 같은폴더에 있는 모든 razor 적용됨
    7) Page에 변수값 받는 방법 
      - counter페이지에 적용 
       @page /counter/{매칭 시킬 변수명:datatype} // string타입은 datatype 기재 안해도 됨
       C#코드에서는 Parameter 어노테이션 추가
    8) C# 코드에서 페이지 이동
        @inject NavigationManager를 주입 해서 navigateTo 메소드에 매개변수로 페이지 명 입력