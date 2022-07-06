
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

3. State관리
    1) CounterState.cs를 추가하여 _count값을 유지
    2) count페이지에서 페이지를 이동하더라도 count값을 유지
    3) CounterState.cs에서 카운트 값을 set 할때 UI 갱신하는 Action을 추가하여 UI 갱신
    4) @impelements 상속 기능 count페이지에 추가 함
    5) StartUp.cs에서 의존성 주입

4. javascript 연동
    1) wwwrot에 test.js 추가
    2) _Host.cshtml에서 사용할 자바 스크립트 추가 test.js(<script src="test.js"></script> 줄 추가)
    3) JSInterop.razor 추가 javascript에서 함수 호출 기능 테스트(반환값 없는 함수, 반환값 이있고 매개변수를 받는 함수)
        JavaScript를 사용 하려면 IJSRuntime을 주입 해 줘야 함.

5. Blazor RankingApp#1
    1) ApplicationDbContext.cs : entity 프레임워크 ORM (자동으로 DB와연동 테이블 생성, CRUD기능)
    2) StartUp 에서  기능 추가
        services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(
                        Configuration.GetConnectionString("DefaultConnection")));
        DefaultConnection => appsettings.json 에 정의 되어 있으며 DB 접속정보를 가지고 옴.
    3) Migrations에 테이블 생성및 쿼리 생성관련 데이터가 생성됨
    4) 프로젝트 새로 생성시 인증 선택을 하면 인증 관련된 설정들이 자동 생성 됨

6. Blazor RankingApp#2
    1) GameResult.cs Model 생성
    2) ApplicationDbContext.cs 에서 DB와 연결할 모델 설정
        public DbSet<GameResult> GameResults { get; set; } // 해당 부분 추가 해 주면 테이블 생성 및 모델과 DB객체간 자동 연결
    3) Nuget 패키지 관리자를 열어 add-migration RankingServic(RankingService는마이그레이션에      
        추가될 cs 파일의이름)
        ApplicationDbContext 모델들을 마이그레이션 파일로 생성함.
        -예) 4.0 버전에는 A 모델, B 모델이 있었고  3.0에는 A모델만 있었다고 가정 할때
             3.0 버전으로 낮추게 되면 디비에서 B모델에 대한 테이블 삭제도 자동 처리됨
    4) update-database add-migration에 추가한 정보를 토대로 DB에 최신화 함
    5) RankingService.cs 생성 하여 생성자를 생성해 Entity 모델을 디펜던시를 이용해 주입 받고
        DB에서 데이터를 가지고 오는 Read 메소드 생성, StatUp에서 디펜던시 추가
    6) Ranking.razor UI파일 생성 디비 데이터 UI로 표시



