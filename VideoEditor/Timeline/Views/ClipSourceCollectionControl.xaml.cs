using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using VideoEditor.Timeline.Views.ViewModels;

namespace VideoEditor.Timeline.Views
{
    /// <summary>
    /// Interaction logic for ClipSourceCollectionControl.xaml
    /// </summary>
    public partial class ClipSourceCollectionControl : UserControl
    {
        #region Timeline Moving Fields
        public bool IsMouseDown;
        public Point OldMousePosition;
        public Point MouseMoveDelta;
        public bool CanMove { get; set; }
        public bool IsSelected { get; set; }
        public bool CanDeselect { get; set; }
        #endregion

        public ClipSourceCollectionViewModel TSourceCollection
        {
            get => this.DataContext as ClipSourceCollectionViewModel;
            set => this.DataContext = value;
        }

        public ClipSourceCollectionControl()
        {
            CanMove = true;
            InitializeComponent();
        }

        #region Moving Timeline

        public void Select()
        {
            IsSelected = true;
        }

        public void Deselect()
        {
            IsSelected = false;
        }

        public void MoveContentLeft(FrameworkElement control, double amount)
        {
            MoveControlHorizontally(control, -amount, amount);
        }
        public void MoveContentRight(FrameworkElement control, double amount)
        {
            MoveControlHorizontally(control, -amount, amount);
        }

        public void MoveControlHorizontally(FrameworkElement control, double amountLeft, double amountRight)
        {
            SetMargin(control, AddToMargin(control.Margin, amountLeft, 0, amountRight, 0));
        }

        public Thickness AddToMargin(Thickness oldMargin, double left, double top, double right, double bottom)
        {
            Thickness realThick = new Thickness(
                oldMargin.Left + left,
                oldMargin.Top + top,
                oldMargin.Right + right,
                oldMargin.Bottom + bottom);
            return realThick;
        }

        public void SetMargin(FrameworkElement control, Thickness newMargin)
        {
            control.Margin = newMargin;
        }

        private void TimelineDraggerLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Select();
            OldMousePosition = e.GetPosition(null);
        }

        private void TimelineDraggerLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Deselect();
            OldMousePosition = e.GetPosition(null);
        }

        public void TryMoveTimelineDragger(MouseEventArgs e)
        {
            if (this != null && CanMove)
            {
                IsMouseDown = (Mouse.LeftButton == MouseButtonState.Pressed) ? true : false;
                if (IsMouseDown && IsSelected)
                {
                    Point mousePos = e.MouseDevice.GetPosition(null);
                    MouseMoveDelta = new Point(OldMousePosition.X - mousePos.X, OldMousePosition.Y - mousePos.Y);

                    if (MouseMoveDelta.X <= -1) MoveContentRight(timelineDragger, MouseMoveDelta.X);
                    if (MouseMoveDelta.X >= 1) MoveContentLeft(timelineDragger, MouseMoveDelta.X);

                    OldMousePosition = mousePos;
                }
                else
                    Deselect();
            }
            else
                Deselect();
        }

        #endregion

        public Point GetDraggerPosition()
        {
            return new Point();
        }

        private void ThisMouseMoved(object sender, MouseEventArgs e)
        {
            TryMoveTimelineDragger(e);
        }
    }
}
