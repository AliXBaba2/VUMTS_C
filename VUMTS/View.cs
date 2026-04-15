namespace VUMTS
{
    public partial class View : Form, IView
    {
        private IModel model;
        private IController controller;

        IModel IView.Model
        {
            get { return model; }
            set { model = value; }
        }
        IController IView.Controller
        {
            get { return controller; }
            set { controller = value; }
        }
        public View()
        {
            InitializeComponent();
        }

        private void onClickStart(object sender, EventArgs e)
        {
            controller.cycleStart();
        }

        public void anzeigen(int entfernung)
        {
            textBox1.Text = entfernung.ToString();
        }

        private void onClickStop(object sender, EventArgs e)
        {
            controller.cycleStop();
        }
    }
}
