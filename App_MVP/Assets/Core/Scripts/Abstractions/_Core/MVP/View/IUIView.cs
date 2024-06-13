namespace Core.Abstractions.MVP
{
    public interface IUIView
    {
        /// <summary>
        /// ���������� � ������ Start ��� ������������� View(������������ � ������)
        /// ��� ���������� �� ������������ ������, ������� ��������� ��������� IUIView,
        /// ������� � ������ ����� ����������� ������� ����� base.Start();
        /// </summary>
        void InitView();

        /// <summary>
        /// ��������� �������� View ������ 
        /// </summary>
        void Hide_ViewInstantly();

        /// <summary>
        /// ��������� ���������� View ������ 
        /// </summary>
        void Show_ViewInstantly();
        
        /// <summary>
        /// �������� View ������ ����� �������� FadeOut 
        /// </summary>
        void Hide_ViewFading();
        
        /// <summary>
        /// ���������� View ������ ����� �������� FadeIn
        /// </summary>
        void Show_ViewFading();
        
        /// <summary>
        /// �������� View ������ ����� �������� Scaling
        /// </summary>
        void Hide_ViewScaling();
        
        /// <summary>
        /// ���������� View ������ ����� �������� Scaling
        /// </summary>
        void Show_ViewScaling();
    }
}
