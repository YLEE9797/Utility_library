
namespace UtilityLib.Chart
{using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    public class CustomChart : Control
    {
        private List<float> _data;  // 데이터
        private Pen _linePen;  // 선 그리기 펜
        private Brush _pointBrush;  // 포인트 그리기 브러쉬

        public CustomChart()
        {
            _data = new List<float>();
            _linePen = new Pen(Color.Blue, 2);  // 선 색상 및 두께
            _pointBrush = Brushes.Red;  // 포인트 색상
            this.DoubleBuffered = true;  // 깜박임 방지
        }

        // 데이터 설정 메서드
        public void SetData(List<float> data)
        {
            _data = data;
            Invalidate();  // 차트를 다시 그리기
        }

        // 차트 그리기 메서드
        public void DrawChart(Graphics g, float xMin, float xMax, float yMin, float yMax)
        {
            float width = this.ClientSize.Width;
            float height = this.ClientSize.Height;

            if (_data.Count > 1)
            {
                // 데이터 점 사이 간격 설정
                float pointSpacing = width / (_data.Count - 1);

                // 첫 번째 점 설정
                PointF prevPoint = new PointF(0, height - ((_data[0] - yMin) / (yMax - yMin) * height));

                // X축과 Y축 그리기
                g.DrawLine(Pens.Black, 0, height, width, height);  // X축 (수평)
                g.DrawLine(Pens.Black, 0, 0, 0, height);          // Y축 (수직)

                // X축과 Y축 값 그리기
                for (int i = 0; i < _data.Count; i++)
                {
                    float x = i * pointSpacing;
                    float y = height - ((_data[i] - yMin) / (yMax - yMin) * height);

                    // 포인트 그리기 (빨간색 원)
                    g.FillEllipse(_pointBrush, x - 4, y - 4, 8, 8);

                    // X축, Y축 값
                    if (i % (_data.Count / 5) == 0)
                        g.DrawString(i.ToString(), this.Font, Brushes.Black, x, height - 20);  // X축 값
                }

                // 데이터 선 그리기
                for (int i = 1; i < _data.Count; i++)
                {
                    float x = i * pointSpacing;
                    float y = height - ((_data[i] - yMin) / (yMax - yMin) * height);

                    // 선 그리기
                    g.DrawLine(_linePen, prevPoint, new PointF(x, y));

                    // 이전 점 업데이트
                    prevPoint = new PointF(x, y);
                }
            }
        }

        // 차트 그리기 메서드 (범위 인자 추가)
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            float xMin = 0, xMax = 10;  // 기본 X축 범위 설정
            float yMin = 0, yMax = 100; // 기본 Y축 범위 설정

            // 차트 그리기 메서드 호출
            DrawChart(g, xMin, xMax, yMin, yMax);
        }
    }


}
