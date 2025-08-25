✅ 센서 및 하드웨어 제어 관련 클래스
SeatPositionSensor
- 자동차 시트의 위치정보를 감지하고 제공하는 센서와 그 데이터를 다루는 로직을 캡슐화한 클래스
- 시트의 슬라이드 틸트의 높이,리클라인의 위치를 실시간으로 측정

- 위치값 읽기(0)
- 범위 확인(0)
- 원점 위치 판단(0)
- 변화 감지(0)


HeaterControlModule
-OEM 마다 PWM 제어,단계별 온도를 제어 하거나 상태 체크하며,기능 정상 여부를 검사 하는 모듈
- 자동차 시트의 내장된 히터(열선을)
- HEATER ON/OFF 제어
- 히터 단계 설정
- 온도 측정
- 발열 여부 검사
- 자동 타이머 종료
- 과열 보호 감지

VentilationControlUnit
- 시트 내부에 장착된 팬(Fan 또는 Blower)을 제어해서 운전석 조주석에 공기를 순환시키는 시스템을
관리하는 클래스.
-통풍 ON/OFF 제어
-통량 단계 설정
-팬 동작 상태 확인
-시간 기반 동작 검사
- 팬 회전수 측정 
- 통풍 정상 여부 검사


ReclineMotorController
- 이 클래스는 등받이(Backrest) 부분의 기울기를 조절하는 리클라인 모터를 구동, 정지, 현재 위치 확인, 기능 검사, 한계 위치 감지 등의 작업을 수행하는 모듈
- 모터 작동 제어
- 현재 각도 확인
- 모터 구동 상태 확인
- 원점 복귀 가능
- 과도한 기울기 방지
- 시간 기반 동작
- 기능 검사

SlideMotorController
SlideMotorController 는 시트의 슬라이드 모터를 앞으로/뒤로 이동시키는 제어 명령, 현재 위치 측정, 한계 위치 감지, 원점 복귀, 기능 정상 여부 확인 등을 수행하는 클래스야.
- 슬라이드 앞뒤/이동
- 현재 위치 측정
- 원점 복귀
- 최대/최소 위치 감지
- 모터 동작 상태 추적
- 슬라이드 거리 측정
- 기능 테스트

HeightAdjustMotor
HeightAdjustMotor 는 자동차 시트의 높낮이 조절 기능을 담당하는 모터를 제어하는 클래스
- 위/아래 이동 제어
- 현재 높이 측정
- 최대/최소 위치 감지
- 원점 복귀 가능
- 이동 거리 계산
- 정상 작동 검사

RelaxMotorUnit
- RelaxMotorUnit은 자동차 시트의 릴랙스(휴식) 기능을 담당하는 모터 제어 클래스
-릴렉스 모터 작동
-동작 방향 제어
-현재 위치 측정
-원점 복귀
-동작 범위 제한
-정상 작동 검사


OccupantSensorInterface
자동차 시트에 사람이 앉아 있는지 감지하는 센서(Occupant Detection Sensor, ODS)와 통신하는 인터페이스 클래스야.
- 탑승자 유무 감지
- 무게 측정
- 무게 기반 분류
- 센서 연결 상태 확인
- 에어백 제어와 연동


WeightSensorReader
- 무게센서 초기화
- 무게 측정값 읽기
- 필터링 처리
- 임계값 설정
- 센서상태 확인
- 로그 기능

CANBusCommunicator


✅ 검사 항목 클래스
PositionLimitChecker (슬라이드 등 한계 위치 검사)

HeaterFunctionTester

VentilationFunctionTester

ReclineAngleChecker

HeightAdjustmentTester

RelaxFunctionTester

MassageFunctionChecker

SeatCushionFirmnessTester

BackrestFirmnessTester

SensorResponseValidator

✅ 검사 시나리오 및 로직
InspectionScenario

TestSequenceRunner

AutoCycleTester

MotorOverloadDetector

SpeedMeasurementUnit

OperationTimeLogger

FunctionRetryHandler

ZeroPointCalibrator

SeatInitializationRoutine

CycleCountValidator

✅ 비전 검사 및 UI 관련
SeatImageAnalyzer

StitchPatternDetector

ContaminationInspector

ColorMismatchChecker

DefectClassifier

LiveCameraViewer

CaptureFrameManager

InspectionResultDisplayer

AnomalyHighlightDrawer

PictureBoxRefresher

✅ 데이터 저장/로그/통신
InspectionDataLogger

TestResultUploader

BarcodeScanner

PartNumberDecoder

DatabaseUploader

InspectionSummaryGenerator

ReportPrinter

PLCCommandDispatcher

NetworkStatusMonitor

ErrorCodeTranslator

