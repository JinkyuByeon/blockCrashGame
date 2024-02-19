Visual Studio 
software team
C#
mini game 

좌표 ( x, y)
picture event 

Ball_x, Ball_y, score 변수는 게임에서 사용되는 정수형 변수
Ball_movement() 메서드는 공의 움직임을 제어합니다. 공은 좌표를 변경하고, 벽에 닿으면 반사
Get_Score() 메서드는 공이 블록에 닿을 때마다 점수를 증가
Game_over() 메서드는 점수가 17 이상이 되면 "You Win"을 표시하고, 공이 화면 아래로 떨어지면 "Game over"를 표시
Form1_KeyDown 이벤트 핸들러는 키보드 입력을 처리하여 플레이어의 위치를 조정
timer1_Tick 이벤트 핸들러는 타이머가 발생할 때마다 공의 움직임을 갱신하고 점수를 계산하며, 게임 종료 여부를 확인
