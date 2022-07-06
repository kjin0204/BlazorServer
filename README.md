
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

2. Form, Validation
    1) WeatherForecast 모델에 입력조건 어노테이션 적용 
      - using System.ComponentModel.DataAnnotations; 필요
      - [Required(ErrorMessage = "Need TemperatureC!")] // 빈칸으로 입력하면 에러 남
      - [Range(typeof(int), "-100", "100")] //int 입력 범위
      - [StringLength(10, MinimumLength = 2, ErrorMessage = "2~10")] //string 입력 범위

    2) FetchData.razor에 팝업 템플릿 적용됨
        if (_showPopup)
        {
            <div class="modal" style="display:block" role="dialog">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" @onclick="ClosePopup">
                                <span area-hidden="true">X</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <EditForm Model="_addForecast" OnValidSubmit="SaveForecast">
                                @*form validation 기능 ON*@
                                <DataAnnotationsValidator />
                                @*에러가 있으면 메시지 상세 출력*@
                                <ValidationSummary />
                                <label for="TemperatureC">TemperatureC</label>
                                <InputNumber class="form-control" placeholder="TemperatureC" @bind-Value="_addForecast.TemperatureC" />
                                <label for="Summary">TemperatureC</label>
                                <InputText class="form-control" placeholder="Summary" @bind-Value="_addForecast.Summary" />
                                <br />
                                <button class="btn btn-primary" type="submit">Save</button>

                            </EditForm>
                        </div>
                    </div>
                </div>
            </div>
        }

    3) <label for="id1"/>
       <input id="id1"/> 
        label에 for 속성과 input에 id 속성을 맞춰주면 라벨을 눌렀을때 해당 input 이 선택됨
       